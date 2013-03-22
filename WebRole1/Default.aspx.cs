using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectBD();
        }
    }

    /// <summary>
		///
		/// </summary>
		public void ConnectBD()
		{
		  try
		  {
		    string ConnectString = "Server=tcp:r8ygkjh4fu.database.windows.net,1433;Database=[notetaloc-spike3];User ID=groupeagilealithis@r8ygkjh4fu;Password={PASS};Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
		    using (System.Data.SqlClient.SqlConnection objConn = new System.Data.SqlClient.SqlConnection(ConnectString))
		    {
		    }
		  }
		  catch { throw; }
}

}
