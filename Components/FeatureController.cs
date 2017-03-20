/*
' Copyright (c) 2015-2016 Satrabel.be
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Entities.Modules;

namespace Satrabel.OpenFiles.Components
{
    public class FeatureController : IUpgradeable //: ModuleSearchBase //,IPortable 
    {
        #region Optional Interfaces

        /*
        public string ExportModule(int ModuleID)
        {
            string xml = "";
            OpenContentController ctrl = new OpenContentController();
            var content = ctrl.GetFirstContent(ModuleID);
            if ((content != null))
            {
                xml += "<opencontent>";
                xml += "<json>" + XmlUtils.XMLEncode(content.Json) + "</json>";
                xml += "</opencontent>";
            }
            return xml;
        }
        public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        {
            OpenContentController ctrl = new OpenContentController();
            XmlNode xml = Globals.GetContent(Content, "opencontent");
            var content = new OpenContentInfo()
            {
                ModuleId = ModuleID,
                Json = xml.SelectSingleNode("json").InnerText,
                CreatedByUserId = UserID,
                CreatedOnDate = DateTime.Now,
                LastModifiedByUserId = UserID,
                LastModifiedOnDate = DateTime.Now,
                Html = ""
            };
            ctrl.AddContent(content);
        }
         */
        #region ModuleSearchBase
        /*
        public override IList<SearchDocument> GetModifiedSearchDocuments(ModuleInfo modInfo, DateTime beginDateUtc)
        {
            var searchDocuments = new List<SearchDocument>();
            OpenContentController ctrl = new OpenContentController();
            var content = ctrl.GetFirstContent(modInfo.ModuleID);
            if (content != null &&
                (content.LastModifiedOnDate.ToUniversalTime() > beginDateUtc &&
                 content.LastModifiedOnDate.ToUniversalTime() < DateTime.UtcNow))
            {
                var searchDoc = new SearchDocument
                {
                    UniqueKey = modInfo.ModuleID.ToString(),
                    PortalId = modInfo.PortalID,
                    Title = modInfo.ModuleTitle,
                    Description = content.Title,
                    Body = content.Json,
                    ModifiedTimeUtc = content.LastModifiedOnDate.ToUniversalTime()
                };
                searchDocuments.Add(searchDoc);
            }
            return searchDocuments;
        }
         */
        #endregion
        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}
        #endregion

        public string UpgradeModule(string version)
        {
            string res = "";
            if (version == "03.02.00")
            {
                Lucene.LuceneController.Instance.IndexAll();
            }
            return version + res;
        }
    }
}