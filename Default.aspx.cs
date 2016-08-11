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
   // string nameOfService = "Spooler";
    string domainName = "TURNER";
    string userName = "dkrynveniuk";
    string userPassword = "Lord0516";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    { try { if (!Page.IsPostBack) { } } catch (Exception) { throw; } }

    #region "Button Event Handlers"
    protected void btnStart_Click(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "Spooler";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }

    protected void btnStop_Click(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "Spooler";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                
                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    #endregion

    #region "Start/Stop Window Service"
    private void StartWindowService(String servicename)
    {
        ServiceController svcController = new ServiceController(servicename);
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

    private void StopWindowService(string servicename)
    {
        
        ServiceController svcController = new ServiceController(servicename);
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
    protected void btnStart_Click1(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQCASSrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStart_Click2(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQDCESrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click1(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQCASSrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click2(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQDCESrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStart_Click3(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQDMESrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStart_Click4(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQDRESrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStart_Click5(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQSchSrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStart_Click6(object sender, EventArgs e)
    {
        try
        {
            //set the service
            string service = "EQSPESrv";

            //--need to impersonate with the user having appropriate rights to start the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {
                //--write code to start/stop the window service
                StartWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Start Success");
            }
            else
                Response.Write(service + "Window Service Start Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click3(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQDMESrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click4(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQDRESrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click5(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQSchSrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
    protected void btnStop_Click6(object sender, EventArgs e)
    {
        try
        {
            //--set the service name to change
            string service = "EQSPESrv";
            //--need to impersonate with the user having appropriate rights to stop the service
            Impersonate objImpersonate = new Impersonate(domainName, userName, userPassword);
            if (objImpersonate.impersonateValidUser())
            {

                StopWindowService(service);
                objImpersonate.undoImpersonation();
                Response.Write(service + "Window Service Stop Success");
            }
            else
                Response.Write(service + "Window Service Stop Failed");
        }
        catch (Exception Ex)
        { Response.Write(Ex.Message + Ex.InnerException.Message); }
    }
}
