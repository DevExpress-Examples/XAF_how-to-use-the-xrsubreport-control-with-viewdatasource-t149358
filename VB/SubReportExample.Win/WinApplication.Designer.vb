﻿Namespace SubReportExample.Win
    Partial Public Class SubReportExampleWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New SubReportExample.Module.SubReportExampleModule()
            Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.reportsModuleV2 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsWindowsFormsModuleV2 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            ' reportsModuleV2
            '
            Me.reportsModuleV2.EnableInplaceReports = True
            Me.reportsModuleV2.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
            Me.reportsModuleV2.ShowAdditionalNavigation = False
            ' 
            ' SubReportExampleWindowsFormsApplication
            ' 
            Me.ApplicationName = "SubReportExample"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.objectsModule)
            Me.Modules.Add(Me.reportsModuleV2)
            Me.Modules.Add(Me.reportsWindowsFormsModuleV2)

            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As SubReportExample.Module.SubReportExampleModule
        Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private reportsModuleV2 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsWindowsFormsModuleV2 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
    End Class
End Namespace
