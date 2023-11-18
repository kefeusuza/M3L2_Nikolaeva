using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //создание переменной жизни
    public int health = 5;
    //создание переменной уровня
    public int level = 2;
    //создание переменной скорости
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        //обновляем данные о количестве жизней
        health += level;
        //вывод данных о количестве жизней
        print("Количество жизней:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //структура данных, которая получает позицию игрока
        Vector3 newPosition = transform.position;
        //назодим координаты объекта спустя 1 кадр
        newPosition.z += speed * Time.deltaTime;
        //
        transform.position = newPosition;
    }
}
