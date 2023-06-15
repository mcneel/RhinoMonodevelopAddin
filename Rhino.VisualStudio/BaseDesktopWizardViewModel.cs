﻿namespace Rhino.VisualStudio
{
    public abstract class BaseDesktopWizardViewModel : BaseLocationWizardViewModel
    {
        public bool ShowWindowsDesktop => Host.IsSupportedParameter("WindowsDesktop");

        bool _useWpf;
        public bool UseWpf
        {
            get => _useWpf;
            set => Set(ref _useWpf, value);
        }

        bool _useWinForms;
        public bool UseWinForms
        {
            get => _useWinForms;
            set => Set(ref _useWinForms, value);
        }

        public override void Finish()
        {
            base.Finish();
            if (Host == null)
                return;
                
            if (ShowWindowsDesktop)
            {
                Host.SetParameter("UseWpf", UseWpf.ToString());
                Host.SetParameter("UseWinForms", UseWinForms.ToString());
            }
        }
    }
}