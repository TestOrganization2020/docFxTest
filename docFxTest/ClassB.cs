﻿// If compiling from the command line, compile with: -doc:YourFileName.xml

namespace docFxTest
{
    /// <summary>
    /// Class level summary documentation goes here.
    /// </summary>
    /// <remarks>
    /// Longer comments can be associated with a type or member through
    /// the remarks tag.
    /// </remarks>
    public class ClassB
    {
        /// <summary>
        /// Store for the Name property.
        /// </summary>
        private string _name = null;

        /// <summary>
        /// The class constructor.
        /// </summary>
        public ClassB()
        {
            // TODO: Add Constructor Logic here.
        }

        /// <summary>
        /// Name property.
        /// </summary>
        /// <value>
        /// A value tag is used to describe the property value.
        /// </value>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    throw new System.Exception("Name is null");
                }
                return _name;
            }
        }

        /// <summary>
        /// Description for SomeMethod.
        /// </summary>
        /// <param name="s"> Parameter description for s goes here.</param>
        /// <seealso cref="System.String">
        /// You can use the cref attribute on any tag to reference a type or member
        /// and the compiler will check that the reference exists.
        /// </seealso>
        public void SomeMethod(string s)
        {
        }

        /// <summary>
        /// Some other method.
        /// </summary>
        /// <returns>
        /// Return values are described through the returns tag.
        /// </returns>
        /// <seealso cref="SomeMethod(string)">
        /// Notice the use of the cref attribute to reference a specific method.
        /// </seealso>
        public int SomeOtherMethod()
        {
            return 0;
        }

        public int InterfaceMethod(int n)
        {
            return n * n;
        }

        ///// <summary>
        ///// The entry point for the application.
        ///// </summary>
        ///// <param name="args"> A list of command line arguments.</param>
        //static int Main(System.String[] args)
        //{
        //    // TODO: Add code to start application here.
        //    return 0;
        //}
    }
}