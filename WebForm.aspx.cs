using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OData
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListPeople();
        }


        protected void ListPeople()
        {
            var serviceRoot = "https://services.odata.org/V4/TripPinServiceRW/";
            var context = new DefaultContainer(new Uri(serviceRoot));

            IEnumerable<Person> people = context.People.Execute();

            GridViewPerson.DataSource = people;
            GridViewPerson.DataBind();

        }
    }
}