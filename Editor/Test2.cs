#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.UnityLinker;
using UnityEngine;
using UnityEditor;

namespace Test.Editor
{
    public class LinkXmlInstaller : IUnityLinkerProcessor
    {
        int IOrderedCallback.callbackOrder => 0;
        string IUnityLinkerProcessor.GenerateAdditionalLinkXmlFile(BuildReport report, UnityLinkerBuildPipelineData data)
        {
            // This is pretty ugly, but it was the only thing I could think of in order to reliably get the path to link.xml
            const string linkXmlGuid = "8d7cb6ae6b9603c49bb23799d7e53a4f"; // copied from link.xml.meta
            var assetPath = AssetDatabase.GUIDToAssetPath(linkXmlGuid);
            // assets paths are relative to the unity project root, but they don't correspond to actual folders for
            // Packages that are embedded. I.e. it won't work if a package is installed as a git submodule
            // So resolve it to an absolute path:
            return Path.GetFullPath(assetPath);
        }
        void IUnityLinkerProcessor.OnBeforeRun(BuildReport report, UnityLinkerBuildPipelineData data)
        {
        }
        void IUnityLinkerProcessor.OnAfterRun(BuildReport report, UnityLinkerBuildPipelineData data)
        {
        }
    }
}
#endif
