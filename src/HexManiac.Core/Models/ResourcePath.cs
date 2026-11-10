using System;
using System.IO;

namespace HavenSoft.HexManiac.Core.Models {
   /// <summary>
   /// Locates HMA's bundled reference files (resources/...).
   /// They live next to the application, which is not always the current directory:
   /// a shortcut with a different 'Start in', a command line, or another process hosting HexManiac.Core.
   /// </summary>
   public static class ResourcePath {
      /// <param name="relativePath">A path like "resources/tableReference.txt".</param>
      /// <returns>The path beside the application if it exists there, otherwise the original relative path.</returns>
      public static string Get(string relativePath) {
         var besideApp = Path.Combine(AppContext.BaseDirectory, relativePath);
         return File.Exists(besideApp) || Directory.Exists(besideApp) ? besideApp : relativePath;
      }
   }
}
