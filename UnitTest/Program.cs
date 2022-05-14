using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using LibraryManagementSystem;
namespace UnitTest
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

        }

        [Test]
        public void Login_Test1()
        {
            LibraryManagementSystem.login login = new login();

            Assert.True(login.Login());
        }


    }
}
