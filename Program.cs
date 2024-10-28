using System;
using System.Drawing;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace SferciucB_temaCLI
{
    //class SimpleWindow3D : GameWindow
    //{

    //    const float rotation_speed = 180.0f;
    //    float angle;
    //    bool showCube = true;
    //    KeyboardState lastKeyPress;

    //    // Constructor.
    //    public SimpleWindow3D() : base(800, 600)
    //    {
    //        VSync = VSyncMode.On;
    //    }

    //    /**Setare mediu OpenGL și încarcarea resurselor (dacă e necesar) - de exemplu culoarea de
    //       fundal a ferestrei 3D.
    //       Atenție! Acest cod se execută înainte de desenarea efectivă a scenei 3D. */
    //    protected override void OnLoad(EventArgs e)
    //    {
    //        base.OnLoad(e);

    //        GL.ClearColor(Color.Blue);
    //        //GL.Enable(EnableCap.DepthTest);
    //    }

    //    /**Inițierea afișării și setarea viewport-ului grafic. Metoda este invocată la redimensionarea
    //       ferestrei. Va fi invocată o dată și imediat după metoda ONLOAD()!
    //       Viewport-ul va fi dimensionat conform mărimii ferestrei active (cele 2 obiecte pot avea și mărimi 
    //       diferite). */
    //    protected override void OnResize(EventArgs e)
    //    {
    //        base.OnResize(e);

    //        GL.Viewport(0, 0, Width, Height);

    //        double aspect_ratio = Width / (double)Height;

    //        Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
    //        GL.MatrixMode(MatrixMode.Projection);
    //        GL.LoadMatrix(ref perspective);
    //    }

    //    /** Secțiunea pentru "game logic"/"business logic". Tot ce se execută în această secțiune va fi randat
    //        automat pe ecran în pasul următor - control utilizator, actualizarea poziției obiectelor, etc. */
    //    protected override void OnUpdateFrame(FrameEventArgs e)
    //    {
    //        base.OnUpdateFrame(e);

    //        KeyboardState keyboard = OpenTK.Input.Keyboard.GetState();
    //        MouseState mouse = OpenTK.Input.Mouse.GetState();
    //        Point mousePosition = base.PointToClient(new Point(mouse.X, mouse.Y));

    //        // Se utilizeaza mecanismul de control input oferit de OpenTK (include perifcerice multiple, mai ales pentru gaming - gamepads, joysticks, etc.).
    //        if (keyboard[OpenTK.Input.Key.Escape])
    //        {
    //            Exit();
    //            return;
    //        }
    //        else if (keyboard[OpenTK.Input.Key.P] && !keyboard.Equals(lastKeyPress))
    //        {
    //            // Ascundere comandată, prin apăsarea unei taste - cu verificare de remanență! Timpul de reacțieuman << calculator.
    //            if (showCube == true)
    //            {
    //                showCube = false;
    //            }
    //            else
    //            {
    //                showCube = true;
    //            }
    //        }
    //        else if (keyboard[OpenTK.Input.Key.A] && !keyboard.Equals(lastKeyPress))
    //        {
    //            angle -= rotation_speed * (float)e.Time;
    //        }
    //        else if (keyboard[OpenTK.Input.Key.D] && !keyboard.Equals(lastKeyPress))
    //        {
    //            angle += rotation_speed * (float)e.Time;
    //        }
    //        lastKeyPress = keyboard;



    //        if (mouse[OpenTK.Input.MouseButton.Left])
    //        {
    //            // Ascundere comandată, prin clic de mouse - fără testare remanență.
    //            if (showCube == true)
    //            {
    //                showCube = false;
    //            }
    //            else
    //            {
    //                showCube = true;
    //            }
    //        }

    //        if (mousePosition.X < 0)
    //        {
    //            angle -= rotation_speed * (float)e.Time;
    //        }
    //        else if (mousePosition.X > Width / 2)
    //        {
    //            angle += rotation_speed * (float)e.Time;
    //        }
    //    }

    //    /** Secțiunea pentru randarea scenei 3D. Controlată de modulul logic din metoda ONUPDATEFRAME().
    //        Parametrul de intrare "e" conține informatii de timing pentru randare. */
    //    protected override void OnRenderFrame(FrameEventArgs e)
    //    {
    //        base.OnRenderFrame(e);

    //        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

    //        Matrix4 lookat = Matrix4.LookAt(15, 50, 15, 0, 0, 0, 0, 1, 0);
    //        GL.MatrixMode(MatrixMode.Modelview);
    //        GL.LoadMatrix(ref lookat);

    //        //angle += rotation_speed * (float)e.Time;
    //        GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

    //        // Exportăm controlul randării obiectelor către o metodă externă (modularizare).
    //        if (showCube == true)
    //        {
    //            DrawCube();
    //            //DrawAxes_OLD();
    //        }

    //        SwapBuffers();
    //        //Thread.Sleep(1);
    //    }

    //    private void DrawAxes_OLD()
    //    {
    //        GL.Begin(PrimitiveType.Lines);

    //        // X
    //        GL.Color3(Color.Red);
    //        GL.Vertex3(0, 0, 0);
    //        GL.Vertex3(20, 0, 0);

    //        // Y
    //        GL.Color3(Color.Blue);
    //        GL.Vertex3(0, 0, 0);
    //        GL.Vertex3(0, 20, 0);

    //        // Z
    //        GL.Color3(Color.Yellow);
    //        GL.Vertex3(0, 0, 0);
    //        GL.Vertex3(0, 0, 20);


    //        GL.End();
    //    }

    //    // Utilizăm modul imediat!!!
    //    private void DrawCube()
    //    {
    //        GL.Begin(PrimitiveType.Quads);

    //        GL.Color3(Color.Silver);
    //        GL.Vertex3(-1.0f, -1.0f, -1.0f);
    //        GL.Vertex3(-1.0f, 1.0f, -1.0f);
    //        GL.Vertex3(1.0f, 1.0f, -1.0f);
    //        GL.Vertex3(1.0f, -1.0f, -1.0f);

    //        GL.Color3(Color.Honeydew);
    //        GL.Vertex3(-1.0f, -1.0f, -1.0f);
    //        GL.Vertex3(1.0f, -1.0f, -1.0f);
    //        GL.Vertex3(1.0f, -1.0f, 1.0f);
    //        GL.Vertex3(-1.0f, -1.0f, 1.0f);

    //        GL.Color3(Color.Moccasin);

    //        GL.Vertex3(-1.0f, -1.0f, -1.0f);
    //        GL.Vertex3(-1.0f, -1.0f, 1.0f);
    //        GL.Vertex3(-1.0f, 1.0f, 1.0f);
    //        GL.Vertex3(-1.0f, 1.0f, -1.0f);

    //        GL.Color3(Color.IndianRed);
    //        GL.Vertex3(-1.0f, -1.0f, 1.0f);
    //        GL.Vertex3(1.0f, -1.0f, 1.0f);
    //        GL.Vertex3(1.0f, 1.0f, 1.0f);
    //        GL.Vertex3(-1.0f, 1.0f, 1.0f);

    //        GL.Color3(Color.PaleVioletRed);
    //        GL.Vertex3(-1.0f, 1.0f, -1.0f);
    //        GL.Vertex3(-1.0f, 1.0f, 1.0f);
    //        GL.Vertex3(1.0f, 1.0f, 1.0f);
    //        GL.Vertex3(1.0f, 1.0f, -1.0f);

    //        GL.Color3(Color.ForestGreen);
    //        GL.Vertex3(1.0f, -1.0f, -1.0f);
    //        GL.Vertex3(1.0f, 1.0f, -1.0f);
    //        GL.Vertex3(1.0f, 1.0f, 1.0f);
    //        GL.Vertex3(1.0f, -1.0f, 1.0f);

    //        GL.End();
    //    }

    //    [STAThread]
    //    static void Main(string[] args)
    //    {

    //        /**Utilizarea cuvântului-cheie "using" va permite dealocarea memoriei o dată ce obiectul nu mai este
    //           în uz (vezi metoda "Dispose()").
    //           Metoda "Run()" specifică cerința noastră de a avea 30 de evenimente de tip UpdateFrame per secundă
    //           și un număr nelimitat de evenimente de tip randare 3D per secundă (maximul suportat de subsistemul
    //           grafic). Asta nu înseamnă că vor primi garantat respectivele valori!!!
    //           Ideal ar fi ca după fiecare UpdateFrame să avem si un RenderFrame astfel încât toate obiectele generate
    //           în scena 3D să fie actualizate fără pierderi (desincronizări între logica aplicației și imaginea randată
    //           în final pe ecran). */
    //        using (SimpleWindow3D example = new SimpleWindow3D())
    //        {

    //            // Verificați semnătura funcției în documentația inline oferită de IntelliSense!
    //            example.Run(30.0, 0.0);
    //        }
    //    }
    //}

    class SimpleWindow3D : GameWindow
    {
        const float rotation_speed = 180.0f;
        float angleX, angleY;
        Vertex[] triangleVertices;
        int selectedVertex = 0;
        KeyboardState lastKeyPress;

        struct Vertex
        {
            public Vector3 Position;
            public float R, G, B;

            public Vertex(float x, float y, float z, float r, float g, float b)
            {
                Position = new Vector3(x, y, z);
                R = r;
                G = g;
                B = b;
            }
        }

        public SimpleWindow3D() : base(800, 600)
        {
            VSync = VSyncMode.On;
            LoadTriangleCoordinates("triangle.txt");
        }

        private void LoadTriangleCoordinates(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                triangleVertices = new Vertex[3];
                for (int i = 0; i < 3; i++)
                {
                    string[] coords = lines[i].Split(' ');
                    float x = float.Parse(coords[0]);
                    float y = float.Parse(coords[1]);
                    float z = float.Parse(coords[2]);
                    triangleVertices[i] = new Vertex(x, y, z, 1.0f, 1.0f, 1.0f);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la încărcarea coordonatelor triunghiului: " + ex.Message);
                triangleVertices = new Vertex[]
                {
                    new Vertex(0.0f, 1.0f, 0.0f, 1.0f, 1.0f, 1.0f),
                    new Vertex(-1.0f, -1.0f, 0.0f, 1.0f, 1.0f, 1.0f),
                    new Vertex(1.0f, -1.0f, 0.0f, 1.0f, 1.0f, 1.0f)
                };
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.Blue);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = OpenTK.Input.Keyboard.GetState();
            MouseState mouse = OpenTK.Input.Mouse.GetState();
            Point mousePosition = base.PointToClient(new Point(mouse.X, mouse.Y));

            // Selecția vertexului curent (0, 1, sau 2)
            if (keyboard[OpenTK.Input.Key.Number1]) selectedVertex = 0;
            if (keyboard[OpenTK.Input.Key.Number2]) selectedVertex = 1;
            if (keyboard[OpenTK.Input.Key.Number3]) selectedVertex = 2;

            // Modificarea culorii pentru vertexul selectat
            if (keyboard[OpenTK.Input.Key.R]) triangleVertices[selectedVertex].R = Math.Min(triangleVertices[selectedVertex].R + 0.01f, 1.0f);
            if (keyboard[OpenTK.Input.Key.G]) triangleVertices[selectedVertex].G = Math.Min(triangleVertices[selectedVertex].G + 0.01f, 1.0f);
            if (keyboard[OpenTK.Input.Key.B]) triangleVertices[selectedVertex].B = Math.Min(triangleVertices[selectedVertex].B + 0.01f, 1.0f);
            if (keyboard[OpenTK.Input.Key.T]) triangleVertices[selectedVertex].R = Math.Max(triangleVertices[selectedVertex].R - 0.01f, 0.0f);
            if (keyboard[OpenTK.Input.Key.Y]) triangleVertices[selectedVertex].G = Math.Max(triangleVertices[selectedVertex].G - 0.01f, 0.0f);
            if (keyboard[OpenTK.Input.Key.U]) triangleVertices[selectedVertex].B = Math.Max(triangleVertices[selectedVertex].B - 0.01f, 0.0f);

            // Afișăm valorile RGB ale vertexului selectat în consolă
            Console.WriteLine($"Vertex {selectedVertex}: R = {triangleVertices[selectedVertex].R}, G = {triangleVertices[selectedVertex].G}, B = {triangleVertices[selectedVertex].B}");

            // Rotirea camerei cu mouse-ul
            if (mouse[OpenTK.Input.MouseButton.Left])
            {
                angleX += (mouse.X - Width / 2) * 0.1f;
                angleY += (mouse.Y - Height / 2) * 0.1f;
            }

            lastKeyPress = keyboard;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 lookat = Matrix4.LookAt(5, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Rotate(angleX, 0.0f, 1.0f, 0.0f); // Rotire pe axa Y
            GL.Rotate(angleY, 1.0f, 0.0f, 0.0f); // Rotire pe axa X

            DrawTriangle(); // Randăm triunghiul

            SwapBuffers();
        }

        private void DrawTriangle()
        {
            GL.Begin(PrimitiveType.Triangles);

            foreach (var vertex in triangleVertices)
            {
                GL.Color3(vertex.R, vertex.G, vertex.B); // Setăm culoarea specifică fiecărui vertex
                GL.Vertex3(vertex.Position);
            }

            GL.End();
        }

        [STAThread]
        static void Main(string[] args)
        {
            using (SimpleWindow3D example = new SimpleWindow3D())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}