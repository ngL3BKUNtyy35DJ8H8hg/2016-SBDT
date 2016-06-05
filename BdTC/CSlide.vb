Option Strict On
Option Explicit On 

Imports System.IO
Imports System.Xml

<Serializable()> Public Class CSlide
    Private mValue As String
    Private mID As Integer
    Private mSymbols As String
    Private mChecked As Boolean
    Private m_DaLayKH As Boolean = False
    Private m_TyLeLayKH As Single = 1

    Public Sub New(ByVal strValue As String, ByVal intID As Integer, ByVal strSymbols As String, ByVal bChecked As Boolean)
        mValue = strValue
        mID = intID
        mSymbols = strSymbols
        mChecked = bChecked
        m_DaLayKH = False
    End Sub

    Public Sub New()
        mValue = ""
        mID = 0
        mSymbols = ""
        mChecked = False
        m_DaLayKH = False
    End Sub

    Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal Value As Integer)
            mID = Value
        End Set
    End Property

    Property Value() As String
        Get
            Return mValue
        End Get
        Set(ByVal Value As String)
            mValue = Value
        End Set
    End Property

    Property Checked() As Boolean
        Get
            Return mChecked
        End Get
        Set(ByVal Value As Boolean)
            mChecked = Value
        End Set
    End Property

    Property TyLeLayKH() As Single
        Get
            Return m_TyLeLayKH
        End Get
        Set(ByVal value As Single)
            m_TyLeLayKH = value
        End Set
    End Property

    Property DaLayKH() As Boolean
        Get
            Return m_DaLayKH
        End Get
        Set(ByVal Value As Boolean)
            m_DaLayKH = Value
        End Set
    End Property

    Property Symbols() As String
        Get
            Return mSymbols
        End Get
        Set(ByVal Value As String)
            mSymbols = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return mValue
    End Function

End Class

Public Class CSlides
    Inherits System.Collections.CollectionBase

    Public Sub Add(ByVal aSlide As CSlide)
        List.Add(aSlide)
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal aSlide As CSlide)
        If index > Count Or index < 0 Then
            System.Windows.Forms.MessageBox.Show("Index not valid!")
        ElseIf index = Count Then
            List.Add(aSlide)
        Else
            List.Insert(index, aSlide)
        End If
    End Sub

    Public Sub Remove(ByVal index As Integer)
        If index > Count - 1 Or index < 0 Then
            System.Windows.Forms.MessageBox.Show("Index not valid!")
        Else
            List.RemoveAt(index)
        End If
    End Sub

    Public Sub Remove(ByVal aSlide As CSlide)
        Me.List.Remove(aSlide)
    End Sub

    Default Public ReadOnly Property Item(ByVal index As Integer) As CSlide
        Get
            Return CType(List.Item(index), CSlide)
        End Get
    End Property

    Public Sub Update(ByVal aSlide As CSlide, ByVal pKH As String, ByVal pTyLeLayKH As Single, ByVal pDaLayKH As Boolean)
        aSlide.Symbols = pKH
        aSlide.TyLeLayKH = pTyLeLayKH
        aSlide.DaLayKH = pDaLayKH
    End Sub

    Public Function GetItemByID(ByVal pId As Integer) As CSlide
        Dim aSlide As CSlide
        For Each aSlide In List
            If aSlide.ID = pId Then
                Return aSlide
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Public Function MoveItem(ByVal pItemId As Integer, ByVal pDestItemID As Integer) As Integer
        Dim i As Integer = -1
        Dim pItem As CSlide = GetItemByID(pItemId)
        Dim aSlide As CSlide
        'dim pItemNew as CSlide 
        Remove(pItem)
        For Each aSlide In list
            i += 1
            If aSlide.ID = pDestItemID Then
                InsertAt(i, pItem)
                Return i
                Exit For
            End If
        Next
        Return -1
    End Function

    Public Function GetMaxID() As Integer
        Dim iMax As Integer = 0
        Dim aSlide As CSlide
        For Each aSlide In list
            If aSlide.ID > iMax Then
                iMax = aSlide.ID
            End If
        Next
        Return iMax
    End Function

    Public Sub Slides2File(ByVal pMap As AxMapXLib.AxMap, ByVal pFileName As String)
        'Dim sw As New StreamWriter(pFileName)
        Dim sw As New StringWriter

        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        Slides2xml(pMap, wr)

        wr.Close()
        Dim strKQ As String = sw.ToString()

        Dim sw2 As New StreamWriter(pFileName)

        sw2.Write(strKQ)
        sw2.Close()

    End Sub

    Public Function Slides2String(ByVal pMap As AxMapXLib.AxMap) As String
        'Dim sw As New StreamWriter(pFileName)
        Dim sw As New StringWriter

        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        Slides2xml(pMap, wr)

        wr.Close()

        Return sw.ToString()
    End Function

    Private Sub Slides2xml(ByVal pMap As AxMapXLib.AxMap, ByRef wr As XmlTextWriter)

        Dim mSlide As CSlide

        wr.WriteStartElement("Slides")
        wr.WriteAttributeString("BDLON", pMap.CenterX.ToString)
        wr.WriteAttributeString("BDLAT", pMap.CenterY.ToString)
        wr.WriteAttributeString("BDZOOM", pMap.Zoom.ToString)

        For Each mSlide In List
            wr.WriteStartElement("Slide")
            wr.WriteAttributeString("Name", mSlide.Value)
            wr.WriteAttributeString("Checked", mSlide.Checked.ToString)
            wr.WriteAttributeString("TyLe", mSlide.TyLeLayKH.ToString)
            wr.WriteAttributeString("DaLayKH", mSlide.DaLayKH.ToString)
            wr.WriteAttributeString("Symbols", mSlide.Symbols)
            'wr.WriteAttributeString("Desc", mSlide.Desc)
            'wr.WriteAttributeString("DonViBC", mSlide.DonViBC)
            'wr.WriteAttributeString("AFN", mSlide.AttFileName)
            wr.WriteElementString("ID", mSlide.ID.ToString)
            wr.WriteEndElement()
        Next

        wr.WriteEndElement()

    End Sub

End Class
