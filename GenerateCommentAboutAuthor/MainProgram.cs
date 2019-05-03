//
//
// GENERATE COMMENT ABOUT AUTHOR is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// RISAL WALANGADI, either version 3 of the License
//
// GENERATE COMMENT ABOUT AUTHOR is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see https://www.gnu.org/licenses/gpl.txt
//
// RISAL WALANGADI
//
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GenerateComment
{
   static class MainProgram
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FrmMain());
      }
   }
}
