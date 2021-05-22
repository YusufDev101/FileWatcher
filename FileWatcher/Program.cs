using FileWatcher.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
    class Program
    {
        // Set controller.
        private static FileWatcherController FileWatcherController;

        static void Main(string[] args)
        {
            try
            {
                FileWatcherController = new FileWatcherController();

                // Call Methods
                FileWatcherController.FileWatcher();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                throw;
            }
        }
    }
}
