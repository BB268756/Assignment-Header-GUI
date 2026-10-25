Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.IO

Public Class NativeHandler
    <StructLayout(LayoutKind.Sequential)>
    Public Structure Colour
        Public red As Integer
        Public green As Integer
        Public blue As Integer
    End Structure
    
    <StructLayout(LayoutKind.Sequential)>
    Public Structure Line
        Public x As Integer
        Public y As Integer
        Public lineHieght As Integer
        Public seperator As Char
        Public colour As Colour
        Public text As String
    End Structure
    
    <StructLayout(LayoutKind.Sequential)>
    Public Structure Image
        Public width As Integer
        Public height As Integer
        Public isQuadChannel As Boolean
        Public name As String
        Public x As Integer
        Public y As Integer
        Public channels As Integer
    End Structure
    
    <DllImport("dynamic_header_provider.dll",EntryPoint:="generateAbstract",CallingConvention:=CallingConvention.Cdecl,CharSet:=CharSet.Ansi)>
    Public Shared Sub AbstractGenerator(
                                                                                                        ByRef lines As Line,
                                                                                                        ByVal lineCount As Integer,
                                                                                                        ByRef image As Image,
                                                                                                        ByVal imageCount As Integer,
                                                                                                        ByVal width As Integer,
                                                                                                        ByVal height As Integer,
                                                                                                        ByVal channels As Integer,
                                                                                                        ByRef background As Colour,
                                                                                                        ByVal fontfile As String,
                                                                                                        ByVal message As String
                                                                                                        ) 
    End Sub
    
    Shared Sub New ()
        NativeLibrary.SetDllImportResolver(GetType(NativeHandler).Assembly, AddressOf ResolveNativeLibrary)
    End Sub
    
    Private Shared Function ResolveNativeLibrary(libraryName As String, assembly As Assembly, searchPath As DllImportSearchPath?) As IntPtr
        If libraryName = "dynamic_header_provider.dll" Then
            Dim path = System.IO.Path.Combine(
                AppContext.BaseDirectory,
                LibraryName)
            
            Return NativeLibrary.Load(path)
        End If
    End Function
End Class