using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrkMage : Mage
{
    private void Start()
    {
        Name = "���";
        MakeDamage();
    }

    protected override void MakeDamage()
    {
        base.MakeDamage();
    }

    // ��� ����� ������������ �������� �������, ����� �� ���� ������������� � ���������� ����? ���� ������� ����� ���� ������ 
    // �������� ��� � ���, � ��� ��������� ��� ����������� ����?
}
