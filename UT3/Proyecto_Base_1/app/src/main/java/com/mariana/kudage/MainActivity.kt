package com.mariana.kudage

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import com.mariana.kudage.activities.FormularioActivity

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
//
//        val btnIniciarSesion: Button = findViewById(R.id.boton_iniciar_sesion)
//        val inputCorreo: EditText = findViewById(R.id.input_usuario)
//
//
//        btnIniciarSesion.setOnClickListener{
//            val correoUser = inputCorreo.text.toString()
//
//            if(correoUser.isNotEmpty()){
//                mostrarMensaje("¡¡¡ BIENVENIDO !!!\nCorreo: $correoUser")
//            } else {
//                mostrarMensaje("Ingrese un correo")
//            }
//        }
    }

    private fun mostrarMensaje(mensaje: String) {
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show()
    }

    fun goToFormulario(view: View) {
        val inputCorreo: EditText = findViewById(R.id.input_usuario)
        val textCorreoUser = inputCorreo.text.toString()

        if(textCorreoUser.isNotEmpty()){
            mostrarMensaje("¡¡¡ BIENVENIDO !!!\nCorreo: $textCorreoUser")
            val intent = Intent(this, FormularioActivity::class.java)
            startActivity(intent)

            } else {
                mostrarMensaje("Ingrese un correo")
            }


    }
}