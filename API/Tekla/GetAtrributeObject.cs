using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class GetAtrributeObject
    {

       static public void GetAtrribute(Beam beam, ref Hashtable sValues)
        {
            ArrayList sNames = new ArrayList();
            sNames.Add("NAME");
            sNames.Add("SCREW_NAME");
            sNames.Add("SCREW_TYPE");
            sNames.Add("TYPE");
            sNames.Add("TYPE1");
            sNames.Add("TYPE2");
            sNames.Add("TYPE3");
            sNames.Add("TYPE4");
            sNames.Add("STANDARD");
            sNames.Add("SHORT_NAME");
            sNames.Add("MATERIAL");
            sNames.Add("FINISH");
            sNames.Add("GRADE");

            ArrayList iNames = new ArrayList();
            iNames.Add("DATE");
            iNames.Add("FATHER_ID");
            iNames.Add("GROUP_ID");
            iNames.Add("HIERARCHY_LEVEL");
            iNames.Add("MODEL_TOTAL");
            ArrayList dNames = new ArrayList();
            dNames.Add("PART.HEIGHT");
            dNames.Add("EXTRA_LENGTH");
            dNames.Add("FLANGE_THICKNESS");
            dNames.Add("FLANGE_WIDTH");
            dNames.Add("HEIGHT");
            dNames.Add("LENGTH");
            dNames.Add("PRIMARYWEIGHT");
            dNames.Add("PROFILE_WEIGHT");
            dNames.Add("ROUNDING_RADIUS");
            dNames.Add("LENGTH");
            dNames.Add("DIAMETER");
            dNames.Add("WEIGHT");
            dNames.Add("WIDTH");
            dNames.Add("HEAD_DIAMETER");
            dNames.Add("THICKNESS");
            dNames.Add("WASHER.THICKNESS");
            dNames.Add("WASHER.INNER_DIAMETER");
            dNames.Add("WASHER.OUTER_DIAMETER");
            dNames.Add("WASHER.THICKNESS1");
            dNames.Add("WASHER.INNER_DIAMETER1");
            dNames.Add("WASHER.OUTER_DIAMETER1");
            dNames.Add("WASHER.THICKNESS2");
            dNames.Add("WASHER.INNER_DIAMETER2");
            dNames.Add("WASHER.OUTER_DIAMETER2");
            dNames.Add("NUT.THICKNESS");
            dNames.Add("NUT.INNER_DIAMETER");
            dNames.Add("NUT.OUTER_DIAMETER");
            dNames.Add("NUT.THICKNESS2");
            dNames.Add("NUT.OUTER_DIAMETER2");
            dNames.Add("AREA");
            dNames.Add("VOLUME");


            sValues = new Hashtable(iNames.Count + sNames.Count + dNames.Count);

            beam.GetAllReportProperties(sNames, dNames, iNames, ref sValues);
        }

    }
}
 

