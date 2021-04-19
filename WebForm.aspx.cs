using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
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

        protected void acsButton_Click(object sender, EventArgs e)
        {
            string s = DropDownList_SelectedIndexChanged();
            var context = new DefaultContainer(new Uri("https://services.odata.org/V4/(S(y5tuj04bxbfsxzimbxbnauqg))/TripPinServiceRW/"));
            
            IEnumerable<Person> person = context.People.Execute(); ;
            switch (s)
            {
                case "UserName":
                    person = context.People.OrderBy(c => c.UserName).ToList();
                    break;
                case "LastName":
                    person = context.People.OrderBy(c => c.LastName).ToList();
                    break;
                case "FirstName":
                    person = context.People.OrderBy(c => c.FirstName).ToList();
                    break;
            }
            GridViewPerson.DataSource = person;
            GridViewPerson.DataBind();
        }

        protected void descButton_Click(object sender, EventArgs e)
        {
            string s = DropDownList_SelectedIndexChanged();
            var context = new DefaultContainer(new Uri("https://services.odata.org/V4/(S(y5tuj04bxbfsxzimbxbnauqg))/TripPinServiceRW/"));

            IEnumerable<Person> person = context.People.Execute(); ;
            switch (s)
            {
                case "UserName":
                    person = context.People.OrderByDescending(c => c.UserName).ToList();
                    break;
                case "LastName":
                    person = context.People.OrderByDescending(c => c.LastName).ToList();
                    break;
                case "FirstName":
                    person = context.People.OrderByDescending(c => c.FirstName).ToList();
                    break;
            }
            GridViewPerson.DataSource = person;
            GridViewPerson.DataBind();

        }

        protected string DropDownList_SelectedIndexChanged()
        {
            string sort = SortBy.SelectedValue;
            return sort;
        }

        protected string FilterBy_SelectedIndexChanged()
        {
            string filter = FilterBy.SelectedValue;
            return filter;
        }
        protected string findTextBox()
        {
            string text = TextBox.Text;
            return text;
        }

        public void showFilters(object sender, EventArgs e)
        {
            string s = FilterBy_SelectedIndexChanged();
            string text = findTextBox();
            var context = new DefaultContainer(new Uri("https://services.odata.org/V4/(S(y5tuj04bxbfsxzimbxbnauqg))/TripPinServiceRW/"));

            IEnumerable<Person> person = context.People.Execute(); ;
            switch (s)
            {
                case "UserName":
                    person = context.People.Where(c => c.UserName.Equals(text));
                    break;
                case "LastName":
                    person = context.People.Where(c => c.LastName.Equals(text));
                    break;
                case "FirstName":
                    person = context.People.Where(c => c.FirstName.Equals(text));
                    break;
            }
            GridViewPerson.DataSource = person;
            GridViewPerson.DataBind();
        }
    }
}