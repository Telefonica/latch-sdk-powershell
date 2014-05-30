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
            catch (Exception)
            {
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
            catch (Exception)
            {
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
            catch (Exception)
            {
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
            catch (Exception)
            {
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
            catch (Exception)
            {
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

}
