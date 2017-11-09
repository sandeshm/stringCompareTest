Requirements to run Program:

- Microsoft Visual Studio 2017
- .Net Framework 4.6.1
- Active internet connection to download dependencies

How to Run Tests:

- Open "StringCompareTest.sln" using Microsoft Visual Studio 2017
- Wait for project to load and for dependencies to download
- Build project

On Windows:

- Go to Test -> Windows -> Test Explorer to open Test Explorer Side bar
- Select "Run all" to run tests

On OSX:
- Go to View -> Test to open Unit Tests Side bar
- Select "Run All" to run tests

Tools Used:

I used Nunit as my test framework for this test. I chose Nunit because it is a simple yet powerful test framework that organizes tests in an easy to understand format. It gives good debugging information for failed tests, and support the use of categories if you need to run specific subsets of a test suite. It is also possible to configure tests to be run through the command line, so that you can trigger the tests automatically without using Visual Studio. This is useful for automated testruns against new builds or daily deployments. When running the tests through command line, you can also create reports that can be shared with the team, so that everyone is aware of test failures as soon as they happen. 

Test Strategy:

The purpose of this program is to fully test the functionality C# String.Compare method to ensure it works as described on this page https://msdn.microsoft.com/en-us/library/7aaf32ef(v=vs.110).aspx .

By using the documentation of the method, we are able to determine the expected behaviour of the method using known inputs. We compare this expected behaviour to the value returned when we actually call the String.Compare method, to ensure that the method is working correctly. 

To ensure that all of the method parameters are tested fully, the test cases are grouped by the parameter that they focus on verifying. The first set of tests uses 2 strings, which is the smallest number of arguments allowed for the method. The length index parameters are then tested to ensure they are being applied to the strings before the comparison is done. Then the length parameter is tested alone, and in combination with the index parameter. The StringComparison parameter affects calculations used to compare the strings. Specific strings that evaluate to different results using different StringComparison methods are used to verify this.  