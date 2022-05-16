namespace SimIDExample
{
    public partial class indexx : System.Web.UI.Page
    {
        private void doUpdate(String query)
        {
            var conn_string = "some_connection_string";
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }//end using
        }//end doUpdate
 
 
        protected void submit_Click(object sender, EventArgs e)
        {
            doUpdate(getQuery());
        }//end submit_Click
 
        private String getQuery()
        {
            return "UPDATE Users SET Name = '" + name.Text + "' WHERE UID = '" + ViewState["UID"].ToString() + "'";
        }//end getQuery
    }//end class
}//end namespacewedwe
