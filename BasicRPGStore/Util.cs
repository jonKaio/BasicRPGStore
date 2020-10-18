using System;
using System.Collections.Generic;
using System.Text;

namespace BasicRPGStore
{
    class Util
    {

        /// <summary>
        /// Basic method to display a message in the console.
        /// </summary>
        /// <param name="_msg">text to display</param>
        /// <param name="_clr">clear screen</param>
        public static void Prompt(string _msg, bool _clr = false)
        {
            if (_clr)
                Console.Clear();
            Console.WriteLine(_msg);
        }

        /// <summary>
        /// Prompt and get input from the user.
        /// </summary>
        /// <param name="_msg">text to display</param>
        /// <param name="_clr">clear screen</param>
        /// <returns></returns>
        public static string Ask(string _msg, bool _clr = false)
        {
            Prompt(_msg, _clr);
            return Console.ReadLine();
        }



    }
}
