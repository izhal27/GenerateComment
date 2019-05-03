/*********************************************************************
**                                                                  **
**                     Generate Comment Author                      **
**                      Risal Walangadi ©2019                       **
**                                                                  **
**------------------------------------------------------------------**
**                                                                  **
**  File Name : MessageHelper.cs                                    **
**  Description : Class helper untuk menampilkan message            **
**  License : GNU GPL v3.0                                          **
**  https://www.gnu.org/licenses/gpl.txt                            **
**                                                                  **
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateComment
{
   public static class MessageHelper
   {
      public static void Error(Exception ex)
      {
         MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
   }
}
