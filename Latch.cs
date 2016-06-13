/*
    Latch Powershell SDK - Set of  reusable classes to  allow developers integrate Latch on their applications.
    Copyright (C) 2013 Eleven Paths.
 
    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.
 
    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.
 
    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

*/

using LatchSDK;
using System;
using System.Management.Automation;
using Microsoft.PowerShell.Commands;
using System.Management.Automation.Runspaces;

namespace LatchPowershellSDK
{
    [Cmdlet(VerbsCommon.Get, "PairWithId")]
    public class PairWithId : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String Id { get; set; }        

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(Id))
                {
                    Id = InputHelper.GetUserInput(this, "Id)");
                }                

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.PairWithId(Id), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Pair")]
    public class Pair : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String Token { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(Token))
                {
                    Token = InputHelper.GetUserInput(this, "Token");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Pair(Token), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Status")]
    public class Status : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Status(AccountId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "OperationStatus")]
    public class OperationStatus : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String OperationId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }
                if (String.IsNullOrEmpty(OperationId))
                {
                    OperationId = InputHelper.GetUserInput(this, "OperationId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.OperationStatus(AccountId, OperationId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Unpair")]
    public class Unpair : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Unpair(AccountId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Lock")]
    public class Lock : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Lock(AccountId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "LockOperation")]
    public class LockOperation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String OperationId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }
                if (String.IsNullOrEmpty(OperationId))
                {
                    OperationId = InputHelper.GetUserInput(this, "OperationId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Lock(AccountId, OperationId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Unlock")]
    public class Unlock : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Unlock(AccountId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "UnlockOperation")]
    public class UnlockOperation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String OperationId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }
                if (String.IsNullOrEmpty(OperationId))
                {
                    OperationId = InputHelper.GetUserInput(this, "OperationId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.Unlock(AccountId, OperationId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "History")]
    public class History : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.History(AccountId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "HistoryInterval")]
    public class HistoryInterval : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String AccountId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String From { get; set; }
        [Parameter(Position = 4, Mandatory = false)]
        public String To { get; set; }

        protected override void ProcessRecord()
        {
            try
            {                
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(AccountId))
                {
                    AccountId = InputHelper.GetUserInput(this, "AccountId");
                }
                if (String.IsNullOrEmpty(From))
                {
                    From = InputHelper.GetUserInput(this, "From");
                }
                if (String.IsNullOrEmpty(To))
                {
                    To = InputHelper.GetUserInput(this, "To");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.History(AccountId, DateTime.Parse(From), DateTime.Parse(To)), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "Operations")]
    public class Operations : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String ParentOperationId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(ParentOperationId))
                {
                    ParentOperationId = InputHelper.GetUserInput(this, "ParentOperationId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(String.IsNullOrEmpty(ParentOperationId) ? latch.GetOperations() : latch.GetOperations(ParentOperationId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "CreateOperation")]
    public class CreateOperation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String ParentId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String Name { get; set; }
        [Parameter(Position = 4, Mandatory = false)]
        public String TwoFactor { get; set; }
        [Parameter(Position = 5, Mandatory = false)]
        public String LockOnRequest { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                Latch.FeatureMode twoFactor, lockOnRequest = Latch.FeatureMode.DISABLED;
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(ParentId))
                {
                    ParentId = InputHelper.GetUserInput(this, "ParentId");
                }
                if (String.IsNullOrEmpty(Name))
                {
                    Name = InputHelper.GetUserInput(this, "Name");
                }
                if (String.IsNullOrEmpty(TwoFactor))
                {
                    TwoFactor = InputHelper.GetUserInput(this, String.Format("TwoFactor \"( {0} | {1} | {2} )\"", 
                        Latch.FeatureMode.DISABLED.ToString(), Latch.FeatureMode.MANDATORY.ToString(), Latch.FeatureMode.OPT_IN.ToString()));
                }
                if (String.IsNullOrEmpty(LockOnRequest))
                {
                    LockOnRequest = InputHelper.GetUserInput(this, String.Format("Name \"( {0} | {1} | {2} )\"",
                        Latch.FeatureMode.DISABLED.ToString(), Latch.FeatureMode.MANDATORY.ToString(), Latch.FeatureMode.OPT_IN.ToString()));
                }                

                Enum.TryParse(TwoFactor, true, out twoFactor);
                Enum.TryParse(LockOnRequest, true, out lockOnRequest);

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.CreateOperation(ParentId, Name, twoFactor, lockOnRequest), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "RemoveOperation")]
    public class RemoveOperation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String OperationId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(OperationId))
                {
                    OperationId = InputHelper.GetUserInput(this, "OperationId");
                }

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.RemoveOperation(OperationId), true);
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "UpdateOperation")]
    public class UpdateOperation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public String AppId { get; set; }
        [Parameter(Position = 1, Mandatory = false)]
        public String SecretKey { get; set; }
        [Parameter(Position = 2, Mandatory = false)]
        public String OperationId { get; set; }
        [Parameter(Position = 3, Mandatory = false)]
        public String Name { get; set; }
        [Parameter(Position = 4, Mandatory = false)]
        public String TwoFactor { get; set; }
        [Parameter(Position = 5, Mandatory = false)]
        public String LockOnRequest { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                Latch.FeatureMode twoFactor, lockOnRequest = Latch.FeatureMode.DISABLED;
                if (String.IsNullOrEmpty(AppId))
                {
                    AppId = InputHelper.GetUserInput(this, "AppId");
                }
                if (String.IsNullOrEmpty(SecretKey))
                {
                    SecretKey = InputHelper.GetUserInput(this, "SecretKey");
                }
                if (String.IsNullOrEmpty(OperationId))
                {
                    OperationId = InputHelper.GetUserInput(this, "OperationId");
                }
                if (String.IsNullOrEmpty(Name))
                {
                    Name = InputHelper.GetUserInput(this, "Name");
                }
                if (String.IsNullOrEmpty(TwoFactor))
                {
                    TwoFactor = InputHelper.GetUserInput(this, String.Format("TwoFactor \"( {0} | {1} | {2} )\"",
                        Latch.FeatureMode.DISABLED.ToString(), Latch.FeatureMode.MANDATORY.ToString(), Latch.FeatureMode.OPT_IN.ToString()));
                }
                if (String.IsNullOrEmpty(LockOnRequest))
                {
                    LockOnRequest = InputHelper.GetUserInput(this, String.Format("Name \"( {0} | {1} | {2} )\"",
                        Latch.FeatureMode.DISABLED.ToString(), Latch.FeatureMode.MANDATORY.ToString(), Latch.FeatureMode.OPT_IN.ToString()));
                }

                Enum.TryParse(TwoFactor, true, out twoFactor);
                Enum.TryParse(LockOnRequest, true, out lockOnRequest);

                Latch latch = new Latch(AppId, SecretKey);
                WriteObject(latch.UpdateOperation(OperationId, Name, twoFactor, lockOnRequest));
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }

    public static class InputHelper
    {
        public static String GetUserInput(PSCmdlet sender, string parameterName)
        {            
            while (true)
            {
                var result = sender.InvokeCommand.InvokeScript(String.Format("Read-Host {0}", parameterName));
                if (result != null)
                {                    
                    return result[0].ToString();
                }
            }
        }
    }

#if (DEBUG)
    [Cmdlet(VerbsCommon.Get, "Debugger")]
    public class Debugger : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                System.Diagnostics.Debugger.Launch();
                InvokeCommand.InvokeScript(String.Format("Write-Host {0}", "Launching debugger..."));
            }
            catch (Exception ex)
            {
                InvokeCommand.InvokeScript(String.Format("Write-Host Error: \"{0}\"", ex.Message));
            }
        }
    }
#endif

}
