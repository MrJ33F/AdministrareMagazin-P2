using System.Runtime.InteropServices;
using System;

namespace CustomUI.Classes
{
    internal class NativeMethods
    {
        #region Cursor Functions
        ///<summary>
        ///
        /// Incarcam resursele specifice cursorului de la executabil asociata cu instanta aplicatiei.
        /// </summary>
        /// <param name="hInstance">
        /// Un handler la o instanta din modul la care fisierul sau executabil contine cursorul care trebuie incarcat.
        /// 
        /// </param>
        /// 
        ///<param name="lpCursorName">
        /// Numele resurselor cursorului care trebuie incarcat.
        /// </param>
        [DllImport("user32.dll")]
        internal static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);


        ///<summary>
        ///Setam modelul cursorului
        /// </summary>
        /// 
        ///<param name"hCursor">
        ///Un handler la cursor.
        ///</param>
        [DllImport("user32.dll")]
        internal static extern IntPtr SetCursor(IntPtr hCursor);
        #endregion
    }
}
