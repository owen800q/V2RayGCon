﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace V2RayGCon.Views
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVmessServToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportVmessLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vmessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.v2rayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAllServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyAddrToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.protocolConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protocolHttpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protocolSocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.systemProxyModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysProxyDirectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysProxyHttpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadV2rayCoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvServers = new System.Windows.Forms.ListView();
            this.colmIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmAlias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmActivate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmStream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmWspath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmEnc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmDisguise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripMenuActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.vmessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v2rayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.buttomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.ctxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.proxyToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVmessServToolStripMenuItem,
            this.ImportVmessLinkToolStripMenuItem,
            this.toolStripSeparator5,
            this.copyAllToolStripMenuItem,
            this.deleteAllServerToolStripMenuItem,
            this.toolStripSeparator9,
            this.exportAllServerToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            resources.ApplyResources(this.operationToolStripMenuItem, "operationToolStripMenuItem");
            // 
            // addVmessServToolStripMenuItem
            // 
            this.addVmessServToolStripMenuItem.Name = "addVmessServToolStripMenuItem";
            resources.ApplyResources(this.addVmessServToolStripMenuItem, "addVmessServToolStripMenuItem");
            this.addVmessServToolStripMenuItem.Click += new System.EventHandler(this.addVmessServToolStripMenuItem1_Click);
            // 
            // ImportVmessLinkToolStripMenuItem
            // 
            this.ImportVmessLinkToolStripMenuItem.Name = "ImportVmessLinkToolStripMenuItem";
            resources.ApplyResources(this.ImportVmessLinkToolStripMenuItem, "ImportVmessLinkToolStripMenuItem");
            this.ImportVmessLinkToolStripMenuItem.Click += new System.EventHandler(this.ImportLinkToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vmessToolStripMenuItem1,
            this.v2rayToolStripMenuItem1});
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            resources.ApplyResources(this.copyAllToolStripMenuItem, "copyAllToolStripMenuItem");
            // 
            // vmessToolStripMenuItem1
            // 
            this.vmessToolStripMenuItem1.Name = "vmessToolStripMenuItem1";
            resources.ApplyResources(this.vmessToolStripMenuItem1, "vmessToolStripMenuItem1");
            this.vmessToolStripMenuItem1.Click += new System.EventHandler(this.CopyAllVmessLinkToolStripMenuItem_Click);
            // 
            // v2rayToolStripMenuItem1
            // 
            this.v2rayToolStripMenuItem1.Name = "v2rayToolStripMenuItem1";
            resources.ApplyResources(this.v2rayToolStripMenuItem1, "v2rayToolStripMenuItem1");
            this.v2rayToolStripMenuItem1.Click += new System.EventHandler(this.CopyAllV2RayLinkToolStripMenuItem_Click);
            // 
            // deleteAllServerToolStripMenuItem
            // 
            this.deleteAllServerToolStripMenuItem.Name = "deleteAllServerToolStripMenuItem";
            resources.ApplyResources(this.deleteAllServerToolStripMenuItem, "deleteAllServerToolStripMenuItem");
            this.deleteAllServerToolStripMenuItem.Click += new System.EventHandler(this.deleteAllServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // exportAllServerToolStripMenuItem
            // 
            this.exportAllServerToolStripMenuItem.Name = "exportAllServerToolStripMenuItem";
            resources.ApplyResources(this.exportAllServerToolStripMenuItem, "exportAllServerToolStripMenuItem");
            this.exportAllServerToolStripMenuItem.Click += new System.EventHandler(this.exportAllServerToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // proxyToolStripMenuItem
            // 
            this.proxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyAddrToolStripTextBox,
            this.toolStripSeparator3,
            this.protocolConfigToolStripMenuItem,
            this.protocolHttpStripMenuItem,
            this.protocolSocksToolStripMenuItem,
            this.toolStripSeparator4,
            this.activateToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem4,
            this.systemProxyModeToolStripMenuItem});
            this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
            resources.ApplyResources(this.proxyToolStripMenuItem, "proxyToolStripMenuItem");
            // 
            // proxyAddrToolStripTextBox
            // 
            resources.ApplyResources(this.proxyAddrToolStripTextBox, "proxyAddrToolStripTextBox");
            this.proxyAddrToolStripTextBox.Name = "proxyAddrToolStripTextBox";
            this.proxyAddrToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proxyAddrToolStripTextBox_KeyUp);
            this.proxyAddrToolStripTextBox.TextChanged += new System.EventHandler(this.proxyAddrToolStripTextBox_TextChange);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // protocolConfigToolStripMenuItem
            // 
            this.protocolConfigToolStripMenuItem.Name = "protocolConfigToolStripMenuItem";
            resources.ApplyResources(this.protocolConfigToolStripMenuItem, "protocolConfigToolStripMenuItem");
            this.protocolConfigToolStripMenuItem.Click += new System.EventHandler(this.protocolConfigToolStripMenuItem_Click);
            // 
            // protocolHttpStripMenuItem
            // 
            this.protocolHttpStripMenuItem.Name = "protocolHttpStripMenuItem";
            resources.ApplyResources(this.protocolHttpStripMenuItem, "protocolHttpStripMenuItem");
            this.protocolHttpStripMenuItem.Click += new System.EventHandler(this.protocolHttpStripMenuItem_Click);
            // 
            // protocolSocksToolStripMenuItem
            // 
            this.protocolSocksToolStripMenuItem.Name = "protocolSocksToolStripMenuItem";
            resources.ApplyResources(this.protocolSocksToolStripMenuItem, "protocolSocksToolStripMenuItem");
            this.protocolSocksToolStripMenuItem.Click += new System.EventHandler(this.protocolSocksToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            resources.ApplyResources(this.activateToolStripMenuItem, "activateToolStripMenuItem");
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click_1);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // systemProxyModeToolStripMenuItem
            // 
            this.systemProxyModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysProxyDirectToolStripMenuItem,
            this.sysProxyHttpToolStripMenuItem});
            this.systemProxyModeToolStripMenuItem.Name = "systemProxyModeToolStripMenuItem";
            resources.ApplyResources(this.systemProxyModeToolStripMenuItem, "systemProxyModeToolStripMenuItem");
            // 
            // sysProxyDirectToolStripMenuItem
            // 
            this.sysProxyDirectToolStripMenuItem.Name = "sysProxyDirectToolStripMenuItem";
            resources.ApplyResources(this.sysProxyDirectToolStripMenuItem, "sysProxyDirectToolStripMenuItem");
            this.sysProxyDirectToolStripMenuItem.Click += new System.EventHandler(this.sysProxyDirectToolStripMenuItem_Click);
            // 
            // sysProxyHttpToolStripMenuItem
            // 
            this.sysProxyHttpToolStripMenuItem.Name = "sysProxyHttpToolStripMenuItem";
            resources.ApplyResources(this.sysProxyHttpToolStripMenuItem, "sysProxyHttpToolStripMenuItem");
            this.sysProxyHttpToolStripMenuItem.Click += new System.EventHandler(this.sysProxyHttpToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configEditorToolStripMenuItem,
            this.qRCodeToolStripMenuItem,
            this.logToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // configEditorToolStripMenuItem
            // 
            this.configEditorToolStripMenuItem.Name = "configEditorToolStripMenuItem";
            resources.ApplyResources(this.configEditorToolStripMenuItem, "configEditorToolStripMenuItem");
            this.configEditorToolStripMenuItem.Click += new System.EventHandler(this.ShowFormConfigToolStripMenuItem_Click);
            // 
            // qRCodeToolStripMenuItem
            // 
            this.qRCodeToolStripMenuItem.Name = "qRCodeToolStripMenuItem";
            resources.ApplyResources(this.qRCodeToolStripMenuItem, "qRCodeToolStripMenuItem");
            this.qRCodeToolStripMenuItem.Click += new System.EventHandler(this.ShowFormQRCodeToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            resources.ApplyResources(this.logToolStripMenuItem, "logToolStripMenuItem");
            this.logToolStripMenuItem.Click += new System.EventHandler(this.ShowFormLogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadV2rayCoreToolStripMenuItem1,
            this.checkUpdateToolStripMenuItem,
            this.toolStripSeparator10,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            // 
            // downloadV2rayCoreToolStripMenuItem1
            // 
            this.downloadV2rayCoreToolStripMenuItem1.Name = "downloadV2rayCoreToolStripMenuItem1";
            resources.ApplyResources(this.downloadV2rayCoreToolStripMenuItem1, "downloadV2rayCoreToolStripMenuItem1");
            this.downloadV2rayCoreToolStripMenuItem1.Click += new System.EventHandler(this.downloadV2rayCoreToolStripMenuItem1_Click);
            // 
            // checkUpdateToolStripMenuItem
            // 
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            resources.ApplyResources(this.checkUpdateToolStripMenuItem, "checkUpdateToolStripMenuItem");
            this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lvServers
            // 
            resources.ApplyResources(this.lvServers, "lvServers");
            this.lvServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmIndex,
            this.colmAlias,
            this.colmOut,
            this.colmHost,
            this.colmPort,
            this.colmActivate,
            this.colmStream,
            this.colmWspath,
            this.colmEnc,
            this.colmDisguise});
            this.lvServers.FullRowSelect = true;
            this.lvServers.GridLines = true;
            this.lvServers.MultiSelect = false;
            this.lvServers.Name = "lvServers";
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            // 
            // colmIndex
            // 
            resources.ApplyResources(this.colmIndex, "colmIndex");
            // 
            // colmAlias
            // 
            resources.ApplyResources(this.colmAlias, "colmAlias");
            // 
            // colmOut
            // 
            resources.ApplyResources(this.colmOut, "colmOut");
            // 
            // colmHost
            // 
            resources.ApplyResources(this.colmHost, "colmHost");
            // 
            // colmPort
            // 
            resources.ApplyResources(this.colmPort, "colmPort");
            // 
            // colmActivate
            // 
            resources.ApplyResources(this.colmActivate, "colmActivate");
            // 
            // colmStream
            // 
            resources.ApplyResources(this.colmStream, "colmStream");
            // 
            // colmWspath
            // 
            resources.ApplyResources(this.colmWspath, "colmWspath");
            // 
            // colmEnc
            // 
            resources.ApplyResources(this.colmEnc, "colmEnc");
            // 
            // colmDisguise
            // 
            resources.ApplyResources(this.colmDisguise, "colmDisguise");
            // 
            // ctxMenuStrip
            // 
            resources.ApplyResources(this.ctxMenuStrip, "ctxMenuStrip");
            this.ctxMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuActivate,
            this.toolStripSeparator2,
            this.stripMenuCopy,
            this.stripMenuDelete,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.moveToolStripMenuItem});
            this.ctxMenuStrip.Name = "ctxMenuStrip";
            // 
            // stripMenuActivate
            // 
            this.stripMenuActivate.Name = "stripMenuActivate";
            resources.ApplyResources(this.stripMenuActivate, "stripMenuActivate");
            this.stripMenuActivate.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // stripMenuCopy
            // 
            this.stripMenuCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vmessToolStripMenuItem,
            this.v2rayToolStripMenuItem});
            this.stripMenuCopy.Name = "stripMenuCopy";
            resources.ApplyResources(this.stripMenuCopy, "stripMenuCopy");
            // 
            // vmessToolStripMenuItem
            // 
            this.vmessToolStripMenuItem.Name = "vmessToolStripMenuItem";
            resources.ApplyResources(this.vmessToolStripMenuItem, "vmessToolStripMenuItem");
            this.vmessToolStripMenuItem.Click += new System.EventHandler(this.CopyVmessLinkToolStripMenuItem_Click);
            // 
            // v2rayToolStripMenuItem
            // 
            this.v2rayToolStripMenuItem.Name = "v2rayToolStripMenuItem";
            resources.ApplyResources(this.v2rayToolStripMenuItem, "v2rayToolStripMenuItem");
            this.v2rayToolStripMenuItem.Click += new System.EventHandler(this.CopyV2RayLinkToolStripMenuItem_Click);
            // 
            // stripMenuDelete
            // 
            this.stripMenuDelete.Name = "stripMenuDelete";
            resources.ApplyResources(this.stripMenuDelete, "stripMenuDelete");
            this.stripMenuDelete.Click += new System.EventHandler(this.deleteStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.toolStripSeparator7,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator6,
            this.buttomToolStripMenuItem});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            resources.ApplyResources(this.moveToolStripMenuItem, "moveToolStripMenuItem");
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            resources.ApplyResources(this.topToolStripMenuItem, "topToolStripMenuItem");
            this.topToolStripMenuItem.Click += new System.EventHandler(this.MoveToTopStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.MoveUpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.MoveDownToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // buttomToolStripMenuItem
            // 
            this.buttomToolStripMenuItem.Name = "buttomToolStripMenuItem";
            resources.ApplyResources(this.buttomToolStripMenuItem, "buttomToolStripMenuItem");
            this.buttomToolStripMenuItem.Click += new System.EventHandler(this.MoveToButtomToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvServers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView lvServers;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stripMenuActivate;
        private System.Windows.Forms.ToolStripMenuItem stripMenuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stripMenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader colmIndex;
        private System.Windows.Forms.ColumnHeader colmOut;
        private System.Windows.Forms.ColumnHeader colmHost;
        private System.Windows.Forms.ColumnHeader colmPort;
        private System.Windows.Forms.ColumnHeader colmActivate;
        private System.Windows.Forms.ColumnHeader colmWspath;
        private System.Windows.Forms.ColumnHeader colmStream;
        private System.Windows.Forms.ColumnHeader colmEnc;
        private System.Windows.Forms.ColumnHeader colmDisguise;
        private System.Windows.Forms.ToolStripMenuItem deleteAllServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox proxyAddrToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem protocolHttpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protocolSocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportVmessLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vmessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem v2rayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vmessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v2rayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem buttomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colmAlias;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem systemProxyModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysProxyDirectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysProxyHttpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem protocolConfigToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem addVmessServToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem downloadV2rayCoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}

