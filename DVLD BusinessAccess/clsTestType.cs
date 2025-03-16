using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessAccess
{
    public class clsTestType
    {

        public enum enTestType { VisionTest = 1,WrittenTest = 2,StreetTest = 3}
        public enTestType TestID { get; set; }
        public string TestTitle { get; set; }
        public string TestTypeDescription { get; set; }

        public float TestFees { get; set; }

        public clsTestType(enTestType testTypeID, string testTypeTitle, string TestTypeDescription, float testTypeFees)
        {
            this.TestID = testTypeID;
            this.TestTitle = testTypeTitle;
            this.TestFees = testTypeFees;
            this.TestTypeDescription = TestTypeDescription;

        }

        public static bool UpdateTest(enTestType testTypeID, string testTypeTitle, string TestTypeDescription, float testTypeFees)
        {
            return clsManageTestData.UpdateTestTypes((byte)testTypeID,  testTypeTitle,  TestTypeDescription,  testTypeFees);
        }

        public static clsTestType Find(enTestType testTypeID)
        {
            string testTypeTitle = "", TestTypeDescription = "";
            float testTypeFees = 0;

            bool found = clsManageTestData.GetTestTypesRecordByID((byte)testTypeID,ref testTypeTitle, ref TestTypeDescription, ref testTypeFees);

            if (found)
                return new clsTestType(testTypeID, testTypeTitle, TestTypeDescription, testTypeFees);
            else
                return null;
        }

        public static DataTable GetTestTypesMenue()
        {

            return clsManageTestData.GetTestTypesMenue();
        }
    }
}
