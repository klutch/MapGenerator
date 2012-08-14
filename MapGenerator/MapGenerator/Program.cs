using System;

namespace MapGenerator
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            MapGeneratorForm form = new MapGeneratorForm();
            form.Show();
            using (Main game = new Main(form))
            {
                game.Run();
            }
        }
    }
#endif
}

