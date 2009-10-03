// ***********************************************************************
// Copyright (c) 2007 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;

namespace NUnit.Core
{
	/// <summary>
	/// The RunState enum indicates whether a test
    /// can be executed. When used on a TestResult
    /// it may also indicate whether the test has
    /// been executed. See individual values for
    /// restrictions on use.
	/// </summary>
	public enum RunState
	{
        /// <summary>
        /// The test is not runnable.
        /// </summary>
		NotRunnable, 

        /// <summary>
        /// The test is runnable. This value would 
        /// normally not appear on a TestResult, since
        /// it would change to Executed.
        /// </summary>
		Runnable,

        /// <summary>
        /// The test can only be run explicitly. Would
        /// normally not appear on a TestResult, since
        /// it would change to Executed or Skipped.
        /// </summary>
		Explicit,

        /// <summary>
        /// The test has been skipped. This value may
        /// appear on a Test when certain attributes
        /// are used to skip the test.
        /// </summary>
		Skipped,

        /// <summary>
        /// The test has been ignored. May appear on
        /// a Test, when the IgnoreAttribute is used.
        /// Appears on a TestResult in that case or
        /// if the test is dynamically ignored.
        /// </summary>
		Ignored,

        /// <summary>
        /// The test has been executed. May only
        /// appear on a TestResult.
        /// </summary>
		Executed
	}
}