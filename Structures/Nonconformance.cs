﻿using System;
using System.Text.RegularExpressions;

namespace Structures
{
    /// <summary>
    /// Class used to make comparation between strings more easy, when comparing
    /// category terms of nonconformances.
    /// </summary>
    public static class CategoryType
    {
		public const String PRECONDITION = "precondition";
        public const String POSTCONDITION = "postcondition";
        public const String INVARIANT = "invariant";
        public const String CONSTRAINT = "constraint";
        public const String EVALUATION = "evaluation";
        public const String MEANINGLESS = "meaningless";
        public const String NEUTRAL = "";
	}

    /// <summary>
    /// Class used to detail nonconformances between code and contracts founded on
    /// C# projects written with CodeContracts clauses.
    /// </summary>
    public class Nonconformance
    {
        // Category of nonconformance
        private String _type;

        // For nonconformance filtering.
        private bool _meaningless = false;
        
        // For results.xml presentation.
        private String _testFileName = "";
        private String _numberedTest = "";
        private String _errorMessage = "";
        private String _className = "";
        private String _methodName = "";
        private String _namespaceName = "";
        private String[] _methodParameters;
        // Categorization module main product.
        private String _likelyCause = "";
        // StackTrace related.
        private String [] _stackTraceOrder;
        private int _stackTraceLenght;

        /// <summary>
        /// Creates Nonconformances using data via VsTest.Console.exe output.
        /// </summary>
        /// <param name="message">The message of error founded.</param>
        /// <param name="stackTrace">The stackTrace generated by nonconformances.</param>
        public Nonconformance(String message, String stackTrace)
        {
            this.SetStackTrace(stackTrace);
            this.SetType();
            if (!IsMeaningless()) {
                this.SetTestInformations();
                this.SetErrorMessage(message);
                this.SetLocation();
            }
        }
        /// <summary>
        /// Define a Likely Cause for current nonconformance.
        /// </summary>
        /// <param name="cause">The likely cause of nonconformance.</param>
        public void SetLikelyCause(string cause)
        {
            this._likelyCause = cause;
        }
        /// <summary>
        /// Return the likely cause of nonconformance.
        /// </summary>
        /// <returns>Likely cause of nonconformance.</returns>
        public string GetLikelyCause()
        {
            return this._likelyCause;
        }
        /// <summary>
        /// Get Namespace where nonconformance was found.
        /// </summary>
        /// <returns>Namespace where nonconformance was found.</returns>
        public string GetNameSpace()
        {
            return this._namespaceName;
        }
        /// <summary>
        /// Get Class name where nonconformance was found.
        /// </summary>
        /// <returns>Class name where nonconformance was found.</returns>
        public string GetClassName()
        {
            return this._className;
        }
        /// <summary>
        /// Get method name where nonconformance was found.
        /// </summary>
        /// <returns>Method name where nonconformance was found.</returns>
        public string GetMethodName()
        {
            return this._methodName;
        }

        public String[] GetParametersArray()
        {
            return this._methodParameters;
        }
        /// <summary>
        /// Get error message thrown when nonconformance were found.
        /// </summary>
        /// <returns>Error message thrown when nonconformance were found.</returns>
        public string GetErrorMessage()
        {
            return this._errorMessage;
        }
        /// <summary>
        /// Get name of file with test that found nonconformance.
        /// </summary>
        /// <returns>Name of file with test that found nonconformance.</returns>
        public string GetTestFileName()
        {
            return this._testFileName;
        }
        /// <summary>
        /// Get name of test method that found nonconformance.
        /// </summary>
        /// <returns>Name of test method that found nonconformance.</returns>
        public string GetNumberedTest()
        {
            return this._numberedTest;
        }
        /// <summary>
        /// Get type of contract that was broken with nonconformance.
        /// </summary>
        /// <returns>Type of contract that was broken with nonconformance.</returns>
        public string GetContractType()
        {
            return this._type;
        }
        /// <summary>
        /// Get StackTrace of nonconformance on the object on a array.
        /// </summary>
        /// <returns>StackTrace of nonconformance on the object on a array.</returns>
        public string[] GetStackTrace()
        {
            return this._stackTraceOrder;
        }
        /// <summary>
        /// For comparison purposes, return a concatenation of values that defines different nonconformances.
        /// </summary>
        /// <returns>Concatenation of values that defines different nonconformances.</returns>
        public String GetIdentifier()
        {
            return this._type + "." + this._namespaceName + "." + this._className + "." + this._methodName;
        }

        // Save StackTrace of nonconformance on the object on a array.
        private void SetStackTrace(string stackTrace)
        {
            this._stackTraceOrder = stackTrace.Trim().Split(new Char[] { '\n' });
            this._stackTraceLenght = this._stackTraceOrder.Length;
        }
        // Set the contract Type of Nonconformance, and defines meaningless classification.
        private void SetType()
        {
            if (this._stackTraceLenght < 5) {
                this.SetMeaningless(true);
                this._type = CategoryType.MEANINGLESS;
            }
            else
            {
                String data = this._stackTraceOrder[2];
                if (data.Contains("Invariant")) {
                    this._type = CategoryType.INVARIANT;
                } else if (data.Contains("Ensures")) {
                    this._type = CategoryType.POSTCONDITION;
                } else if (data.Contains("Requires")) {
                    if (this._stackTraceLenght == 5) {
                        this.SetMeaningless(true);
                        this._type = CategoryType.MEANINGLESS;
                    } else {
                        this._type = CategoryType.PRECONDITION;
                    }
                }
                else
                {
                    // Other Errors, like NullPointerException
                    this.SetMeaningless(true);
                    this._type = CategoryType.MEANINGLESS;
                }
            }
        }
        // Set a new value for isMeaningless expression.
        private void SetMeaningless(bool value)
        {
            this._meaningless = value;
        }
        // Defines if the nonconformance is meaningless or not.
        public bool IsMeaningless()
        {
            return this._meaningless;
        }
        // Set test informations about which TestFile and which TestUnit found nonconformance.
        private void SetTestInformations()
        {
            String test = "RandoopTest";
            String unit = "UnitTest";
            String data = this._stackTraceOrder[this._stackTraceLenght - 1];
            int first = data.LastIndexOf(test) + test.Length;
            int last = data.LastIndexOf("." + unit);
            String number = data.Substring(first, last - first);
            this._testFileName = test + number;
            this._numberedTest = unit + number;
        }
        // Set the Error Message thrown when nonconformance were found.
        private void SetErrorMessage(String message)
        {
            this._errorMessage = message;
        }
        // Fill information related to the location of Nonconformance.
        private void SetLocation()
        {
            // Take line that will tell location of Nonconformance.
            String data;
            if (this._type == CategoryType.INVARIANT) {
                data = this._stackTraceOrder[4];
            } else {
                data = this._stackTraceOrder[3];
            }
            // Fill location information.
            foreach(Match m in Regex.Matches(data, @"(?:(?:([\S]*)[.])|())([^. ]+)[.](.*)([(].*[)])"))
            {
                if (m.Groups[1].Value.Equals(""))
                    this._namespaceName = m.Groups[2].Value;
                else
                    this._namespaceName = m.Groups[1].Value;
                this._className = m.Groups[3].Value;
                this._methodName = m.Groups[4].Value;
                this._methodParameters = (m.Groups[5].Value.Split(','));
            }
        }


        // Override to define different nonconformances.
        public override bool Equals(object obj)
        {
            if((obj is Nonconformance) 
				&& ((Nonconformance) obj).GetIdentifier().Equals(this.GetIdentifier())) { 
			    return true;
		    } else {
			    return false;
		    }
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + this.GetNameSpace().GetHashCode();
            hash = (hash * 7) + this.GetClassName().GetHashCode();
            hash = (hash * 7) + this.GetMethodName().GetHashCode();
            return hash;
        }
    }
}
