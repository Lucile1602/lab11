using OpenTK.Graphics.OpenGL;
using OpenTK3_StandardTemplate_WinForms.helpers;
using OpenTK3_StandardTemplate_WinForms.objects;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OpenTK3_StandardTemplate_WinForms
{
    public partial class MainForm : Form
    {
        private Axes mainAxis;
        private Cubes cub;
        private Camera cam;
        private Scene scene;
        private bool isTransparent = false;
        private bool? rubix = null;
        private int[] textures = new int[2];
        private Point mousePosition;

        private float[] valuesAmbient0 = new float[4];
        private float[] valuesDiffuse0 = new float[4];
        private float[] valuesSpecular0 = new float[4];
        private float[] valuesPosition0 = new float[4];

        private bool lightON = false;
        private bool lightON_0 = false;

        public MainForm()
        {
            InitializeComponent();

            scene = new Scene();

            scene.GetViewport().Load += new EventHandler(this.mainViewport_Load);
            scene.GetViewport().Paint += new PaintEventHandler(this.mainViewport_Paint);
            scene.GetViewport().MouseMove += new MouseEventHandler(this.mainViewport_MouseMove);
            this.Controls.Add(scene.GetViewport());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Randomizer.Init();

            cam = new Camera(scene.GetViewport());

            mainAxis = new Axes(showAxes.Checked);
            cub = new Cubes();

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            LoadTextures();

        }

        private void InitializeLighting()
        {
            float[] valuesAmbientTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
            float[] valuesDiffuseTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] valuesSpecularTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
            float[] valuesPositionTemplate0 = new float[] { 0.0f, 0.0f, 5.0f, 1.0f };

            for (int i = 0; i < valuesAmbientTemplate0.Length; i++)
            {
                valuesAmbient0[i] = valuesAmbientTemplate0[i];
                valuesDiffuse0[i] = valuesDiffuseTemplate0[i];
                valuesSpecular0[i] = valuesSpecularTemplate0[i];
                valuesPosition0[i] = valuesPositionTemplate0[i];
            }
        }
        private void toggleTransparency_Click(object sender, EventArgs e)
        {
            isTransparent = !isTransparent;
            toggleTransparency.Text = isTransparent ? "Transparency: ON" : "Transparency: OFF";

            scene.Invalidate();
        }

        private void rbTexture_Click(object sender, EventArgs e)
        {
            rubix = true;
            cub.SetTexture(textures[0]);
            scene.Invalidate(); 
        }

            private void rbTexture2_Click(object sender, EventArgs e)
        {
            rubix = false;
            cub.SetTexture(textures[1]);
            scene.Invalidate();  
        }

        private void showAxes_CheckedChanged(object sender, EventArgs e)
        {
            mainAxis.SetVisibility(showAxes.Checked);

            scene.Invalidate();
        }

        private void changeBackground_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Randomizer.GetRandomColor());

            scene.Invalidate();
        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
            btnLights.Text = lightON ? "Iluminare ON" : "Iluminare OFF";
            scene.Invalidate();
        }

        private void btnLight0_Click(object sender, EventArgs e)
        {
            if (lightON)
            {
                lightON_0 = !lightON_0;
                btnLight0.Text = lightON_0 ? "Sursa 0 ON" : "Sursa 0 OFF";
                scene.Invalidate();
            }
        }

        private void numericLight0Difuse_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[0] = (float)numericLight0Difuse_Red.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Difuse_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[1] = (float)numericLight0Difuse_Green.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Difuse_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[2] = (float)numericLight0Difuse_Blue.Value / 100;
            scene.Invalidate();
        }


        private void resetScene_Click(object sender, EventArgs e)
        {
            showAxes.Checked = true;
            mainAxis.SetVisibility(showAxes.Checked);

            scene.Reset();
            cam.Reset();

            isTransparent = false;
            toggleTransparency.Text = "Transparency: OFF";
            toggleTransparency.Checked = false; 

            enableRotation.Checked = false;
            enableObjectRotation.Checked = false;

            rubix = null;
            cub.SetTexture(0); 
            rbTexture1.Checked = false;
            rbTexture2.Checked = false;

            InitializeLighting();
            lightON = false;
            lightON_0 = false;
            btnLights.Text = "Iluminare OFF";
            btnLight0.Text = "Sursa 0 OFF";

            scene.Invalidate();
        }

        private void mainViewport_Load(object sender, EventArgs e)
        {
            scene.Reset();
        }

        private void mainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
            scene.Invalidate();
        }

        private void LoadTextures()
        {
            GL.GenTextures(textures.Length, textures);
            LoadTexture(textures[0], "texture.jpg");
            LoadTexture(textures[1], "texture.png");
        }

        private void LoadTexture(int textureId, string filename)
        {
            Bitmap bmp = new Bitmap(filename);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                                                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, textureId);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                          bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                          PixelType.UnsignedByte, data.Scan0);

            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (float)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (float)TextureMagFilter.Linear);
        }
        private void mainViewport_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            cam.SetView();

            if (enableRotation.Checked)
            {
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
            }

            GL.Enable(EnableCap.Texture2D);
            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);

            mainAxis.Draw();

            if (lightON)
            {
                GL.Enable(EnableCap.Lighting);
                //GL.Light(LightName.Light0, LightParameter.Ambient, valuesAmbient0);
                GL.Light(LightName.Light0, LightParameter.Diffuse, valuesDiffuse0);
                GL.Light(LightName.Light0, LightParameter.Specular, valuesSpecular0);

                if (lightON_0)
                {
                    GL.Enable(EnableCap.Light0);
                }
                else
                {
                    GL.Disable(EnableCap.Light0);
                }
            }
            else
            {
                GL.Disable(EnableCap.Lighting);
            }

            if (enableObjectRotation.Checked)
            {
                GL.PushMatrix();
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);

                cub.DrawCubes(isTransparent ? 0.5f : 1.0f);

                GL.PopMatrix();
            }
            else
            {
                cub.DrawCubes(isTransparent ? 0.5f : 1.0f);
            }

            scene.GetViewport().SwapBuffers();
        }

    }
}