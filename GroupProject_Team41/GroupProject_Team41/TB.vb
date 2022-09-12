﻿Option Explicit On
Option Strict On
Option Infer Off
Public Class TB
    Inherits Disease
    Private _vaccines As Vaccine
    Private _numSurvived As Integer

    Public Property vaccines() As Vaccine
        Get
            Return _vaccines
        End Get
        Set(value As Vaccine)
            _vaccines = value
        End Set
    End Property
    Public Property numsurvived() As Integer
        Get
            Return _NumSurvived

        End Get
        Set(value As Integer)
            _NumSurvived = value

        End Set
    End Property
    Public Sub New(name As String, np As Integer, nT As Integer, nA As Integer, nS As Integer, nD As Integer, t As String)
        MyBase.New(name, np, nT, nA, nD, t)
        _numSurvived = nS
    End Sub
    Public Function DeathSurvivalRatio() As String
        Dim min As Integer
        Dim d, s As Integer
        Dim Ratio As String
        min = numdied
        If min > numsurvived Then
            min = numsurvived
        End If
        d = CInt(numdied / min)
        s = CInt(numsurvived / min)
        Ratio = CStr(d & ":" & s)
        Return Ratio
    End Function
    Public Overridable Function SurvivalRate() As Double
        Return (_numSurvived / population) * 100
    End Function
End Class

