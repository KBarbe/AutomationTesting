﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AutomationTesting.CodedUIMaps.Notepad_UIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class Notepad_UIMap
    {
        
        #region Properties
        public Notepad Notepad
        {
            get
            {
                if ((this.mNotepad == null))
                {
                    this.mNotepad = new Notepad();
                }
                return this.mNotepad;
            }
        }
        
        public NotepadMenus NotepadMenus
        {
            get
            {
                if ((this.mNotepadMenus == null))
                {
                    this.mNotepadMenus = new NotepadMenus();
                }
                return this.mNotepadMenus;
            }
        }
        #endregion
        
        #region Fields
        private Notepad mNotepad;
        
        private NotepadMenus mNotepadMenus;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class Notepad : WinWindow
    {
        
        public Notepad()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Untitled - Notepad";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Notepad";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public TextEditor TextEditor
        {
            get
            {
                if ((this.mTextEditor == null))
                {
                    this.mTextEditor = new TextEditor(this);
                }
                return this.mTextEditor;
            }
        }
        #endregion
        
        #region Fields
        private TextEditor mTextEditor;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TextEditor : WinWindow
    {
        
        public TextEditor(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "15";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public WinEdit TextEditor_txt
        {
            get
            {
                if ((this.mTextEditor_txt == null))
                {
                    this.mTextEditor_txt = new WinEdit(this);
                    #region Search Criteria
                    this.mTextEditor_txt.SearchProperties[WinEdit.PropertyNames.Name] = "Text Editor";
                    this.mTextEditor_txt.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mTextEditor_txt;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mTextEditor_txt;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class NotepadMenus : WinWindow
    {
        
        public NotepadMenus()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Untitled - Notepad";
            #endregion
        }
        
        #region Properties
        public NotepadMenuBar NotepadMenuBar
        {
            get
            {
                if ((this.mNotepadMenuBar == null))
                {
                    this.mNotepadMenuBar = new NotepadMenuBar(this);
                }
                return this.mNotepadMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private NotepadMenuBar mNotepadMenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class NotepadMenuBar : WinMenuBar
    {
        
        public NotepadMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "Application";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public FileMenu FileMenu
        {
            get
            {
                if ((this.mFileMenu == null))
                {
                    this.mFileMenu = new FileMenu(this);
                }
                return this.mFileMenu;
            }
        }
        
        public EditMenu EditMenu
        {
            get
            {
                if ((this.mEditMenu == null))
                {
                    this.mEditMenu = new EditMenu(this);
                }
                return this.mEditMenu;
            }
        }
        #endregion
        
        #region Fields
        private FileMenu mFileMenu;
        
        private EditMenu mEditMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class FileMenu : WinMenuItem
    {
        
        public FileMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "File";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public WinMenuItem New_menu
        {
            get
            {
                if ((this.mNew_menu == null))
                {
                    this.mNew_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mNew_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "New\tCtrl+N";
                    this.mNew_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mNew_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mNew_menu;
            }
        }
        
        public WinMenuItem Save_menu
        {
            get
            {
                if ((this.mSave_menu == null))
                {
                    this.mSave_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mSave_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Save\tCtrl+S";
                    this.mSave_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mSave_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mSave_menu;
            }
        }
        
        public WinMenuItem SaveAs_menu
        {
            get
            {
                if ((this.mSaveAs_menu == null))
                {
                    this.mSaveAs_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mSaveAs_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Save As...";
                    this.mSaveAs_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mSaveAs_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mSaveAs_menu;
            }
        }
        
        public WinMenuItem PageSetup_menu
        {
            get
            {
                if ((this.mPageSetup_menu == null))
                {
                    this.mPageSetup_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mPageSetup_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Page Setup...";
                    this.mPageSetup_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mPageSetup_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mPageSetup_menu;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mNew_menu;
        
        private WinMenuItem mSave_menu;
        
        private WinMenuItem mSaveAs_menu;
        
        private WinMenuItem mPageSetup_menu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class EditMenu : WinMenuItem
    {
        
        public EditMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Edit";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public WinMenuItem Undo_menu
        {
            get
            {
                if ((this.mUndo_menu == null))
                {
                    this.mUndo_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUndo_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Undo\tCtrl+Z";
                    this.mUndo_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUndo_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mUndo_menu;
            }
        }
        
        public WinMenuItem Copy_menu
        {
            get
            {
                if ((this.mCopy_menu == null))
                {
                    this.mCopy_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mCopy_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Copy\tCtrl+C";
                    this.mCopy_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mCopy_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mCopy_menu;
            }
        }
        
        public WinMenuItem Paste_menu
        {
            get
            {
                if ((this.mPaste_menu == null))
                {
                    this.mPaste_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mPaste_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Paste\tCtrl+V";
                    this.mPaste_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mPaste_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mPaste_menu;
            }
        }
        
        public WinMenuItem Find_menu
        {
            get
            {
                if ((this.mFind_menu == null))
                {
                    this.mFind_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mFind_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Find...\tCtrl+F";
                    this.mFind_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mFind_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mFind_menu;
            }
        }
        
        public WinMenuItem Replace_menu
        {
            get
            {
                if ((this.mReplace_menu == null))
                {
                    this.mReplace_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mReplace_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Replace...\tCtrl+H";
                    this.mReplace_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mReplace_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mReplace_menu;
            }
        }
        
        public WinMenuItem GoTo_menu
        {
            get
            {
                if ((this.mGoTo_menu == null))
                {
                    this.mGoTo_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mGoTo_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Go To...\tCtrl+G";
                    this.mGoTo_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mGoTo_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mGoTo_menu;
            }
        }
        
        public WinMenuItem TimeDate_menu
        {
            get
            {
                if ((this.mTimeDate_menu == null))
                {
                    this.mTimeDate_menu = new WinMenuItem(this);
                    #region Search Criteria
                    this.mTimeDate_menu.SearchProperties[WinMenuItem.PropertyNames.Name] = "Time/Date\tF5";
                    this.mTimeDate_menu.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mTimeDate_menu.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mTimeDate_menu;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUndo_menu;
        
        private WinMenuItem mCopy_menu;
        
        private WinMenuItem mPaste_menu;
        
        private WinMenuItem mFind_menu;
        
        private WinMenuItem mReplace_menu;
        
        private WinMenuItem mGoTo_menu;
        
        private WinMenuItem mTimeDate_menu;
        #endregion
    }
}