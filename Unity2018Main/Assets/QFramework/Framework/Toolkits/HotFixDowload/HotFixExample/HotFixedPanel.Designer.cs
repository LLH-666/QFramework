// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MyGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public partial class HotFixedPanel
    {
        
        public const string NAME = "HotFixedPanel";
        
        [SerializeField()]
        public UnityEngine.UI.Image Info;
        
        [SerializeField()]
        public UnityEngine.UI.Text HotContenText;
        
        [SerializeField()]
        public UnityEngine.UI.Image HotFixedSlider;
        
        [SerializeField()]
        public UnityEngine.UI.Text HotFixedSliderText;
        
        [SerializeField()]
        public UnityEngine.UI.Text HotFixedInfoText;
        
        private HotFixedPanelData mPrivateData = null;
        
        public HotFixedPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new HotFixedPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            Info = null;
            HotContenText = null;
            HotFixedSlider = null;
            HotFixedSliderText = null;
            HotFixedInfoText = null;
            mData = null;
        }
    }
}
