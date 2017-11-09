/* Take Home Assignment for API SDET Position
 * Sandesh Meghnath
 * 11/7/2017
 */

using NUnit.Framework;
using System;


namespace NunitTest1
{
    [TestFixture()]
    public class Test
    {
        
        //Test 1: Compare 2 matching strings with no other arguments
        //Expected Result: Function will return 0
        [Test()]
        [Category("Basic")]
        public void StringsMatch()
        {
            int result = String.Compare("abcd", "abcd");

            Assert.AreEqual(result, 0);
        }

        //Test 2: Compare 2 strings, where String A is before String B using the default comparison options
        //Expected Result: Function will return -1
        [Test()]
        [Category("Basic")]
        public void StringAbeforeB()
        {
            int result = String.Compare("a", "g");

            Assert.LessOrEqual(result, -1);
        }

        //Test 3: Compare 2 strings where String A comes after String B when using the default comparison options
        //Expected Result: Function will return 1
        [Test()]
        [Category("Basic")]
        public void StringAafterB()
        {
            int result = String.Compare("g", "a");

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 4: Compare 2 strings where String A is null and String B is a regular string. 
        //Expected Result: Function will return -1 since null should come before any string using default comparison options
        [Test()]
        [Category("Basic")]
        public void StringAisNull()
        {
            int result = String.Compare(null, "abc");

            Assert.LessOrEqual(result, -1);
        }

        //Test 5: Compare 2 strings where String A is a regular string and String B is null
        //Expected Result: Function will return 1 since null should come after any string 
        [Test()]
        [Category("Basic")]
        public void StringBisNull()
        {
            int result = String.Compare("abc", null);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 6: Compare 2 strings where both strings are null
        //Expected Result: Function will return 0 since both strings are the same
        [Test()]
        [Category("Basic")]
        public void BothStringsAreNull()
        {
            int result = String.Compare(null, null);

            Assert.AreEqual(result, 0);
        }

        //Test 7: Compare 2 long strings that match
        //Expected Result: Function will return 0 since both strings are the same
        [Test()]
        [Category("Basic")]
        public void LongStringsMatch()
        {
            int result = String.Compare("Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullam.", "Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullam.");

            Assert.AreEqual(result, 0);
        }

        //Test 8: Compare 2 long strings where String A comes before String B 
        //Expected Result: Function will return -1 since String A comes before String B using default comparison options
        [Test()]
        [Category("Basic")]
        public void LongStringsABeforeB()
        {
            int result = String.Compare("Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullal.", "Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullam.");

            Assert.LessOrEqual(result, -1);
        }

        //Test 9: Compare 2 long strings where String A comes after String B
        //Expected Result: Function will return 1 since String Be comes after String B using default comparison options
        [Test()]
        [Category("Basic")]
        public void LongStringsAAfterB()
        {
            int result = String.Compare("Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullan.", "Loremipsumdolorsitamet,consecteturadipiscingelit.Utvelorcijusto.Fusceelementumplaceratestactincidunt.Praesentauctor,loreminplaceratinterdum,ipsumaugueporttitoraugue,egetvehiculatellusdiamacnulla.Duisinterdum,arcuveleleifendfacilisis,diamerattinciduntpurus,vitaecommodotellusmetussitametlorem.Nullameulectusnonantelobortissagittisegetactortor.Morbiegetmolestieerat.Donecdapibusurnaplaceratturpisvestibulum,utcursusquamcursus.Fuscefermentumaliquamdapibus.Maecenasmalesuadabibendumtellus,necaccumsanmaurisvenenatisquis.Maecenasullamcorperexidipsumgravida,quisefficitursemsagittis.Nullamelementumtortormaximusdiamscelerisqueblandit.Sedvolutpatsemaorciiaculis,adictumdiamiaculis.Donecegetconsequaterat,sitametfeugiatlacus.Utvestibulumodiovelconguevehicula.Donecconsecteturloremmauris.Pellentesqueefficiturmolestiemaurisnonpulvinar.Aliquameratvolutpat.Fuscenullam.");

            Assert.GreaterOrEqual(result, 1);
        }


        //Tests focused on Index parameters

        //Test 10: Compare 2 matching strings with minimum index value allowed
        //Expected Result: Function will return 0, since the strings being compared are identical
        [Test()]
        [Category("Index")]
        public void StringswithIndex0Match()
        {
            int result = String.Compare("abcd",0, "abcd",0,4);

            Assert.AreEqual(result, 0);
        }

        //Test 11: Compare 2 matching strings with an index value that starts the comparison in the same place in the middle of the string
        //Expected Result: Function will return 0 since the strings being compared are identical
        [Test()]
        [Category("Index")]
        public void StringswithIndex1Match()
        {
            int result = String.Compare("abcd", 1, "abcd", 1, 3);

            Assert.AreEqual(result, 0);
        }

        //Test 12: Compare 2 different strings with an index value that starts the comparison in the same place in the middle of the string
        //Expected Result: Function will return -1 since String A being compared comes before String B being compared using the default comparison options
        [Test()]
        [Category("Index")]
        public void StringABeforeBwithIndex1()
        {
            int result = String.Compare("abcd", 1, "abce", 1, 3);

            Assert.AreEqual(result, -1);
        }

        //Test 13: Compare 2 different strings with an index value that starts the comparison in the same place in the middle of the string
        //Expected Result: Function will return 1 since String A being compared comes after String B being compared using the default comparison options
        [Test()]
        [Category("Index")]
        public void StringAAfterBwithIndex1()
        {
            int result = String.Compare("abce", 1, "abcd", 1, 3);

            Assert.LessOrEqual(result, 1);
        }

        //Test 14: Compare 2 different strings with different index values. When the index is applied, the strings will match
        //Expected Result: Function will return 0 since the strings being compared match once the index is used. If the index is not applied String A will come after String B and return 1
        [Test()]
        [Category("Index")]
        public void MatchingStringsWithDifferentIndices()
        {
            int result = String.Compare("xxabcd", 3, "abcd", 1, 3);

            Assert.AreEqual(result, 0);
        }

        //Test 15: Compare 2 different strings with different index values. When the index is applied, the String A will come before String B
        //Expected Result: Function will return -1 since String A with the index applied comes before String B with the index applied. If the index is not applied then String A should come after String B
        [Test()]
        [Category("Index")]
        public void StringABeforeBWithDifferentIndices()
        {
            int result = String.Compare("xxabcd", 3, "abce", 1, 3);

            Assert.LessOrEqual(result, -1);
        }

        //Test 16: Compare 2 different strings with different index values. When the index is applied, the String A will come after String B
        //Expected Result: Function will return 1 since String A with the index applied comes after String B with the index applied. If the index is not applied then String A should come before String B
        [Test()]
        [Category("Index")]
        public void StringAAfterBWithDifferentIndices()
        {
            int result = String.Compare("xxabce", 3, "abcd", 1, 3);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 17: Compare 2 different strings with the index equal to the length of the string. This should be the maximum value allowed before returning an exception
        //Expected Result: Function will return 0 since once the index is applied, the strings are the same.
 
        [Test()]
        [Category("Index")]
        public void StringswithIndexEqualtoLength()
        {
            string strA = "abcd";
            string strB = "efgh";

            int result = String.Compare(strA, strA.Length, strB, strB.Length, 1);

            Assert.AreEqual(result, 0);
        }

        //Test 18: Compare 2 different strings with an index greater than the length of the string. 
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is larger than the length of the string
        [Test()]
        [Category("Index")]
        public void BothStringswithIndexLargerThanLength()
        {
            string strA = "abcd";
            string strB = "efgh";

            try
            {
                int result = String.Compare(strA, strA.Length + 1, strB, strB.Length + 1, 1);
            }
            catch(Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 19: Compare 2 different strings where String A has an index greater than the length of the string. 
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is larger than the length of String A
        [Test()]
        [Category("Index")]
        public void StringAwithIndexLargerThanLength()
        {
            string strA = "abcd";
            string strB = "efgh";

            try
            {
                int result = String.Compare(strA, strA.Length + 1, strB, strB.Length , 1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 20: Compare 2 different strings where String B has an index greater than the length of the string. 
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is larger than the length of String B
        [Test()]
        [Category("Index")]
        public void StringBwithIndexLargerThanLength()
        {
            string strA = "abcd";
            string strB = "efgh";

            try
            {
                int result = String.Compare(strA, strA.Length, strB, strB.Length+1, 1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 21: Compare 2 different strings with an index greater than the length of the string. 
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is larger than the length of the string
        [Test()]
        [Category("Index")]
        public void BothStringswithIndexMuchLargerThanLength()
        {
            string strA = "abcd";
            string strB = "efgh";

            try
            {
                int result = String.Compare(strA, strA.Length + 1000, strB, strB.Length + 1000, 1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 22: Compare 2 different strings with an index that is a negative value
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is a negative value
        [Test()]
        [Category("Index")]
        public void BothStringswithNegativeIndex()
        {
            try
            {
                int result = String.Compare("abcd", -1, "abcd", -1, 1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 23: Compare 2 different strings where String A has a negative index value
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is negative for String A
        [Test()]
        [Category("Index")]
        public void StringAwithNegativeIndex()
        {
            try
            {
                int result = String.Compare("abcd", -1, "abcd", 0, 1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }

        //Test 24: Compare 2 different strings where String B has a negative index value
        //Expected Result: Function will return a ArgumentOutOfRangeException because the index is negative for String B
        [Test()]
        [Category("Index")]
        public void StringBwithNegativeIndex()
        {
            try
            {
                int result = String.Compare("abcd", 0, "abcd", -1, 2);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }


        //Tests focused on Length parameter


        //Test 25: Compare 2 short strings with a length parameter that is longer than the length of the Strings
        //Expected Result: Function will return 0 as the strings being compared are the same
        [Test()]
        [Category("Length")]
        public void MatchingStringsWithTooLargeLength()
        {
            int result = String.Compare("abcd", 0, "abcd", 0, 10);

            Assert.AreEqual(result, 0);
        }

        //Test 26: Compare 2 strings where String A comes before String B with a length parameter that is longer than length of both strings 
        //Expected Result: Function will return -1 as String A comes before String B using default comparison parameters
        [Test()]
        [Category("Length")]
        public void StringABeforeBWithTooLargeLength()
        {
            int result = String.Compare("abcd", 0, "efgh", 0, 10);

            Assert.LessOrEqual(result, -1);
        }

        //Test 27: Compare 2 strings where String A comes after String B with a length parameter that is longer than length of both strings 
        //Expected Result: Function will return 1 as String A comes after String B using default comparison parameters 
        [Test()]
        [Category("Length")]
        public void StringAAfterBWithTooLargeLength()
        {
            int result = String.Compare("efgh", 0, "abcd", 0, 10);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 28: Compare 2 matching strings with a length parameter of 0 
        //Expected Result: Function will return 0 as strings of 0 length will match when compared
        [Test()]
        [Category("Length")]
        public void MatchingStringswithLength0()
        {
            int result = String.Compare("abcd", 0, "abcd", 0, 0);

            Assert.AreEqual(result, 0);
        }

        //Test 29: Compare 2 strings where String A comes before String B with a length parameter of 0
        //Expected Result: Function will return 0 as strings of 0 length will match when compared
        [Test()]
        [Category("Length")]
        public void StringABeforeBwithLength0()
        {
            int result = String.Compare("abcd", 0, "efgh", 0, 0);

            Assert.AreEqual(result, 0);
        }

        //Test 30: Compare 2 strings where String A comes after String B with a length parameter of 0
        //Expected Result: Function will return 0 as strings of 0 length will match when compared
        [Test()]
        [Category("Length")]
        public void StringAAfterBwithLength0()
        {
            int result = String.Compare("efgh", 0, "abcd", 0, 0);

            Assert.AreEqual(result, 0);
        }

        //Test 31: Compare 2 strings where String A comes before String B with a length parameter of 2
        //Expected Result: Function will return 0 as strings of 2 length will match when compared. If the length parameter is not used, String A comes before String B. 
        [Test()]
        [Category("Length")]
        public void MatchingStringWithLength2()
        {
            int result = String.Compare("abcd", 0, "abce", 0, 2);

            Assert.AreEqual(result, 0);
        }

        //Test 32: Compare 2 strings where using a negative length parameter
        //Expected Result: Function will return a ArgumentOutOfRangeException exception because the length value cannot be negative
        [Test()]
        [Category("Length")]
        public void StringswithNegativeLength()
        {
            try
            {
                int result = String.Compare("abcd", 0, "abce", 0, -1);
            }
            catch (Exception e)
            {
                string ErrorMsg = e.GetBaseException().ToString();
                ErrorMsg = ErrorMsg.Substring(0, ErrorMsg.IndexOf(Environment.NewLine));

                Assert.AreEqual(ErrorMsg, "System.ArgumentOutOfRangeException: Positive number required.");
                return;
            }
            Assert.Fail();
        }


        // Tests focusing on ComparisonType Parameter


        //Test 33: Compare 2 strings that use different characters using CurrentCulture Comparison type
        //Expected Result: Function will return 0, since the CurrentCulture Comparison type evaulates the "æ" character to be equal to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureStringsMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.CurrentCulture);

            Assert.AreEqual(result, 0);
        }

        //Test 34: Compare 2 strings that use different characters using CurrentCulture Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the CurrentCulture Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureStringAbeforeB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedib", 0, 13, StringComparison.CurrentCulture);

            Assert.LessOrEqual(result, -1);
        }

        //Test 35: Compare 2 strings that use different characters using CurrentCulture Comparison type
        //Expected Result: Function will return 1, since String A comes after String B using the CurrentCulture Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureStringAAfterB()
        {
            int result = String.Compare("encyclopaedib", 0, "encyclopædia", 0, 13, StringComparison.CurrentCulture);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 36: Compare 2 strings that use different characters and different capitalization using CurrentCulture Comparison type
        //Expected Result: Function will return 1, since the CurrentCulture Comparison type is case sensitive
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureCaseMisMatch()
        {
            int result = String.Compare("Encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.CurrentCulture);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 37: Compare 2 strings that use different characters using CurrentCultureIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the CurrentCultureIgnoreCase Comparison type evaulates the "æ" character to be equal to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureIgnoreCaseStringsMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.CurrentCultureIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 38: Compare 2 strings where String A comes before String B using CurrentCultureIgnoreCase Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the CurrentCultureIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureIgnoreCaseStringAbeforeB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedib", 0, 13, StringComparison.CurrentCultureIgnoreCase);

            Assert.LessOrEqual(result, -1);
        }

        //Test 39: Compare 2 strings where String A comes after String B using CurrentCultureIgnoreCase Comparison type
        //Expected Result: Function will return 1, since String A comes after String B using the CurrentCultureIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureIgnoreCaseStringAAfterB()
        {
            int result = String.Compare("encyclopedia", 0, "encyclopædia", 0, 13, StringComparison.CurrentCultureIgnoreCase);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 40: Compare 2 strings with different capitalization using CurrentCultureIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the CurrentCultureIgnoreCase Comparison type ignores case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeCurrentCultureIgnoreCaseCaseMisMatch()
        {
            int result = String.Compare("Encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.CurrentCultureIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 41: Compare 2 different strings using InvariantCulture Comparison type
        //Expected Result: Function will return 0, since the CurrentCultureIgnoreCase Comparison type evaulates the "æ" character to be equal to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureStringsMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.InvariantCulture);

            Assert.AreEqual(result, 0);
        }

        //Test 42: Compare 2 different strings where String A comes before String B using InvariantCulture Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the InvariantCulture Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureStringAbeforeB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedib", 0, 13, StringComparison.InvariantCulture);

            Assert.LessOrEqual(result, -1);
        }

        //Test 43: Compare 2 different strings where String A comes after String B using InvariantCulture Comparison type
        //Expected Result: Function will return 1, since String A comes after String B using the InvariantCulture Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureStringAAfterB()
        {
            int result = String.Compare("encyclopedia", 0, "encyclopædia", 0, 13, StringComparison.InvariantCulture);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 44: Compare 2 strings with different capitalization using InvariantCulture Comparison type
        //Expected Result: Function will return 1, since the InvariantCulture Comparison type uses case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureCaseMisMatch()
        {
            int result = String.Compare("Encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.InvariantCulture);

            Assert.GreaterOrEqual(result, 1);
        }


        //Test 45: Compare 2 different strings using InvariantCultureIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the InvariantCultureIgnoreCase Comparison type evaulates the "æ" character to be equal to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureIgnoreCaseStringsMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.InvariantCultureIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 46: Compare 2 different strings where String A comes before String B using InvariantCultureIgnoreCase Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the InvariantCultureIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureIgnoreCaseStringAbeforeB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopedia", 0, 13, StringComparison.InvariantCultureIgnoreCase);

            Assert.LessOrEqual(result, -1);
        }

        //Test 47: Compare 2 different strings where String A comes after String B using InvariantCultureIgnoreCase Comparison type
        //Expected Result: Function will return -1, since String A comes after String B using the InvariantCultureIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureIgnoreCaseStringAAfterB()
        {
            int result = String.Compare("encyclopedia", 0, "encyclopædia", 0, 13, StringComparison.InvariantCultureIgnoreCase);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 48: Compare 2 strings with different capitalization using InvariantCultureIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the InvariantCultureIgnoreCase Comparison type ignores case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeInvariantCultureIgnoreCaseCaseMisMatch()
        {
            int result = String.Compare("Encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.InvariantCultureIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 49: Compare 2 matching strings using Ordinal Comparison type
        //Expected Result: Function will return 0, since the strings are identical
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalStringMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopædia", 0, 13, StringComparison.Ordinal);

            Assert.AreEqual(result, 0);
        }

        //Test 50: Compare 2 different strings using Ordinal Comparison type
        //Expected Result: Function will return 1, since the Ordinal Comparison type evaulates the "æ" character to be different to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalStringMismatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.Ordinal);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 51: Compare 2 different strings where String A comes before String B using Ordinal Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the Ordinal Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalStringAbeforeB()
        {
            int result = String.Compare("encyclopaedia", 0, "encyclopædia", 0, 13, StringComparison.Ordinal);

            Assert.LessOrEqual(result, -1);
        }

        //Test 52: Compare 2 different strings where String A after before String B using Ordinal Comparison type
        //Expected Result: Function will return 1, since String A comes after String B using the Ordinal Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalStringAAfterB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.Ordinal);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 53: Compare 2 strings with different capitalization using Ordinal Comparison type
        //Expected Result: Function will return 1, since the Ordinal Comparison type uses case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalCaseMisMatch()
        {
            int result = String.Compare("encyclopædia", 0, "Encyclopædia", 0, 13, StringComparison.Ordinal);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 54: Compare 2 matching strings using OrdinalIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the strings are identical
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalIgnoreCaseStringMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopædia", 0, 13, StringComparison.OrdinalIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 55: Compare 2 different strings using OrdinalIgnoreCase Comparison type
        //Expected Result: Function will return 1, since the OrdinalIgnoreCase Comparison type evaulates the "æ" character to be different to "ae"
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalIgnoreCaseStringMismatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopaedia", 0, 13, StringComparison.OrdinalIgnoreCase);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 56: Compare 2 different strings where String A comes before String B using OrdinalIgnoreCase Comparison type
        //Expected Result: Function will return -1, since String A comes before String B using the OrdinalIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalIgnoreCaseStringAbeforeB()
        {
            int result = String.Compare("encyclopaedia", 0, "encyclopædia", 0, 13, StringComparison.OrdinalIgnoreCase);

            Assert.LessOrEqual(result, -1);
        }

        //Test 57: Compare 2 different strings where String A comes before String B using OrdinalIgnoreCase Comparison type
        //Expected Result: Function will return 1, since String A comes before String B using the OrdinalIgnoreCase Comparison type
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalIgnoreCaseStringAAfterB()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopedia", 0, 13, StringComparison.OrdinalIgnoreCase);

            Assert.GreaterOrEqual(result, 1);
        }

        //Test 58: Compare 2 strings with different capitalization using OrdinalIgnoreCase Comparison type
        //Expected Result: Function will return 0, since the OrdinalIgnoreCase Comparison type ignores case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void ComparisonTypeOrdinalIgnoreCaseCaseMisMatch()
        {
            int result = String.Compare("encyclopædia", 0, "Encyclopædia", 0, 13, StringComparison.OrdinalIgnoreCase);

            Assert.AreEqual(result, 0);
        }

        //Test 59: Compare 2 strings with different captializations using boolean argument "true" for comparison type
        //Expected Result: Function will return 0 since using the "true" boolean argument ignores case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void BooleanIgnoreCaseTrueCaseMisMatch()
        {
            int result = String.Compare("encyclopædia", 0, "Encyclopædia", 0, 13, true);

            Assert.AreEqual(result, 0);
        }

        //Test 60: Compare 2 strings with identical captializations using boolean argument "true" for comparison type
        //Expected Result: Function will return 0 since using the strings are identical
        [Test()]
        [Category("ComparisonType")]
        public void BooleanIgnoreCaseTrueCaseMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopædia", 0, 13, true);

            Assert.AreEqual(result, 0);
        }

        //Test 61: Compare 2 strings with different captializations using boolean argument "false" for comparison type
        //Expected Result: Function will return -1 since using the "false" boolean argument uses case when doing comparisons
        [Test()]
        [Category("ComparisonType")]
        public void BooleanIgnoreCaseFalseCaseMisMatch()
        {
            int result = String.Compare("encyclopædia", 0, "Encyclopædia", 0, 13, false);

            Assert.LessOrEqual(result, -1);
        }

        //Test 62: Compare 2 strings with identical captializations using boolean argument "false" for comparison type
        //Expected Result: Function will return 0 since using the strings are identical
        [Test()]
        [Category("ComparisonType")]
        public void BooleanIgnoreCaseFalseCaseMatch()
        {
            int result = String.Compare("encyclopædia", 0, "encyclopædia", 0, 13, false);

            Assert.AreEqual(result, 0);
        }

    }
}
