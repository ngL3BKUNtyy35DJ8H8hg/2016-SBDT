Imports AxMapXLib
Imports Microsoft.VisualBasic.CompilerServices
Imports System

Namespace SaBan
	Friend Module modBanDo
		Friend OLuoiX As Integer = 82

		Friend OLuoiY As Integer = 171

		Friend OLuoiKinhDo As Double = 105.63437

		Friend OLuoiViDo As Double = 21.3691

		Friend OLuoiSize As Integer = 1000

		Friend OluoiXRate As Double = 100.0

		Friend OluoiYRate As Double = 120.0

		Public myMapGst As String = "BanDo\BanDo.gst"

		Public myMapNhoGst As String = "BanDo\BanDoNho.gst"

		Public fBanDoNho As dlgBanDoNho

		Public Const myToolNewDoiTuong As Integer = 2

		Public Const myToolInfo As Integer = 3

		Public Const NHAPNHAYDELAY As Integer = 40

		Public myCoordSysType As Integer = 1

		Public BDSaiSo As Double = 1.0

		Public BDTyLeBanDo As Integer = 100000

		Public BDKinhDo As Double = 104.255

		Public BDViDo As Double = 17.0

		Public Function GetZoomLevel(pMap As AxMap, pTyLeBanDo As Integer) As Double
			Return CDec(pTyLeBanDo) * pMap.MapPaperWidth * modBanDo.BDSaiSo / 100.0
		End Function

		Public Function GetTyLeBD(pMap As AxMap, pZoom As Double) As Integer
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			Return CInt(Math.Round(pMap.Zoom * 100.0 / (pMap.MapPaperWidth * modBanDo.BDSaiSo)))
		End Function
	End Module
End Namespace
