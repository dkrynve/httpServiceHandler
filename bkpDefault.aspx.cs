using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceProcess;

public partial class _Default : System.Web.UI.Page
{
    #region "Class Members"
    string nameOfService = "Spooler";
    string domainName = "TURNER";
    string userName = "USER";
    string userPassword = "PASS";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    { try { if (!Page.IsPostBack) { } } catch (Exception) { throw; } }

    #region "Button Event Handlers"
    protected void btnStart_Click(object sender, EventArgs e)
    {
        try
        {
            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService();
                objImpersonate.undoImpersonation();
                Response.Write(nameOfService + "Window Service Start Success");
            }
            else
                Response.Write(nameOfService + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }

    protected void btnStop_Click(object sender, EventArgs e)
    {
        try
        {
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                StopWindowService();
                objImpersonate.undoImpersonation();
                Response.Write(nameOfService + "Window Service Stop Success");
            }
            else
                Response.Write(nameOfService + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    #endregion

    #region "Start/Stop Window Service"
    private void StartWindowService()
    {
        ServiceController svcController = new ServiceController(nameOfService);
        if (svcController != null)
        {
            try
            {
                if (svcController.Status != ServiceControllerStatus.Running && 
                    svcController.Status != ServiceControllerStatus.StartPending)
                    svcController.Start();
            }
            catch (Exception Ex) { throw; }
        }
    }

    private void StopWindowService()
    {
        ServiceController svcController = new ServiceController(nameOfService);
        if (svcController != null)
        {
            try
            {
                if (svcController.Status == ServiceControllerStatus.Running && 
                    svcController.CanStop)
                {
                    svcController.Stop();
                    svcController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception Ex) { throw; }
        }
    }
    #endregion
}
