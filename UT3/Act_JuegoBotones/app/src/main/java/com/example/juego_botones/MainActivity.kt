package com.example.juego_botones

import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.LinearLayout
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import kotlin.random.Random


class MainActivity : AppCompatActivity() {

    private val numBotones = 10
    private lateinit var llBotonera: LinearLayout


    override fun onCreate(savedInstanceState: Bundle?) {

        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)

        llBotonera = findViewById(R.id.llBotonera)

        //Creamos las propiedades de layout que tendrán los botones.
        val lp = LinearLayout.LayoutParams(
            LinearLayout.LayoutParams.MATCH_PARENT,
            resources.getDimensionPixelSize(R.dimen.button_height)
        )

        // Se genera un número random entre 0 y 9
        val numRandom = Random.nextInt(0, numBotones)

        //Creamos los botones en bucle
        for (i in 0 until numBotones) {
            val button = Button(this)

            //Asignamos propiedades de layout al botón
            button.layoutParams = lp
            button.id = i

            //Asignamos Texto al botón
            button.text = "Botón " + String.format("%02d", i)

            if (button.id == numRandom) {
                //Asignamos el Listener
                button.setOnClickListener(buttonClickListener2(i))

            } else {
                //Asignamos el Listener
                button.setOnClickListener(buttonClickListener(i))
            }

            //Añadimos el botón a la botonera
            llBotonera.addView(button)
        }

    }

    private fun buttonClickListener(index: Int): View.OnClickListener {
        return View.OnClickListener {
            Toast.makeText(
                this@MainActivity,
                "Sigue buscando",
                Toast.LENGTH_SHORT
            ).show()
        }
    }

    private fun buttonClickListener2(index: Int): View.OnClickListener {
        return View.OnClickListener {
            Toast.makeText(
                this@MainActivity,
                "ME ENCONTRASTE!!",
                Toast.LENGTH_SHORT
            ).show()
        }
    }

}