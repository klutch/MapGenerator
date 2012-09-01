using System;

namespace MapGenerator
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MapGeneratorForm form = new MapGeneratorForm();
            Main game = new MapGenerator.Main(form);
            form.main = game;
            form.Show();
            game.Run();
        }
    }
#endif
}

