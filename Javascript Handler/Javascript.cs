using System;
using System.Web.UI;

namespace Javascript_Handler
{
    public class Javascript
    {
        private Page page { get; set; }

        public Javascript(Page page)
        {
            this.page = page;
        }

        public void alert(string message = "")
        {
            string jquery = @"alert('" + message + "')";
            ScriptManager.RegisterStartupScript(page, this.GetType(), new Random().Next(0, 999949).ToString(), jquery, true);
        }

        public void addScript(string script)
        {
            ScriptManager.RegisterStartupScript(page, this.GetType(), new Random().Next(0, 999949).ToString(), script, true);
        }
    }
}
