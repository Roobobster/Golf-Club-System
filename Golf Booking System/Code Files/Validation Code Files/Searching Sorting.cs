using System.Collections.Generic;

namespace Validation
{
    public class SearchingSorting
    {
        //This returns where in the list the searchkey is unless it isn't in there where instead it returns -1
        //int max in exclusive, int min is inclusive
        public static int BinarySearch(List<string> strArray, int intMin, int intMax, string strSearchKey)
        {
      
            if (intMin > intMax)
            {
                return -1;
            }
            else
            {
                int intMid = (intMin + intMax) / 2;

                //If the search values is equal to the mid point
                if (string.Compare(strArray[intMid], strSearchKey, true) == 0)
                    return intMid;

                //if the serach value is greater than the mid value
                else if (string.Compare(strSearchKey, strArray[intMid], true) > 0)
                    return BinarySearch(strArray, (intMid + 1), intMax, strSearchKey);

                //If the search value is less than the mid value
                else
                    return BinarySearch(strArray, intMin, (intMid - 1), strSearchKey);


            }

        }

    }
}