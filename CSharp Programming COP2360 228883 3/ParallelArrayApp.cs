using System;
using static System.Console;
using System.Windows.Forms;

#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_3>                              
///   Class:          <Class ParallelArrayApp>                                   
///   Description:    <Description Assignment 3>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 02/27/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:02/27/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------
#pragma warning restore 1587

namespace CSharp_Programming_COP2360_228883_3
{
    class ParallelArrayApp
    {
        // Since compile time and runtime initialization is confused so much, I included the article explaining in detail compile time.
        // The following two arrays will perform a compile-time initialization
        // http://www.dotnetfunda.com/articles/show/2433/compile-time-and-runtime-initialization-of-2d-array-in-csharp
        private readonly int[] _array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        private readonly int[] _array2 = new int[] { 22, 32, 14, 54, 23, 71, 234, 63, 91, 11};
        private int[] _array3;
        private string _message;
        public ParallelArrayApp()
        {
            CalculateArray3();
            ShowMessageBox();
        }

        #region Assignment 3-B

        private void CalculateArray3()
        {
            var arrayLength = Math.Min(_array1.Length, _array2.Length);

            _array3 = new int[arrayLength];

            for (var i = 0; i < _array3.Length; i++)
            {
                _array3[i] = _array1[i] * _array2[i];
            }
        }

        private void ShowMessageBox()
        {
            const string title = "Parallel Arrays";
            _message = "Array1 * Array2 = Array3\n\n";
            _message += "Array1\tArray2\tArray3\n";

            for (int i = 0; i < _array3.Length; i++)
            {
                _message += $"{_array1[i]}\t{_array2[i]}\t{_array3[i]}\n";
            }

            WriteLine("\n\nPlease click OK in the message box to continue...");
            var result = MessageBox.Show(_message, title, MessageBoxButtons.OK, MessageBoxIcon.None,
     MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
        }
        #endregion
    }
}
