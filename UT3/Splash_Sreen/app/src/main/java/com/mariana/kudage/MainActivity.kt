package com.mariana.kudage

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.EditText
import android.widget.Toast
import com.mariana.kudage.activities.FormularioActivity

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    private fun mostrarMensaje(mensaje: String) {
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show()
    }

    fun goToFormulario(view: View) {
        val inputCorreo: EditText = findViewById(R.id.main_et_usuario)
        val textCorreoUser = inputCorreo.text.toString()

        val inputContra: EditText = findViewById(R.id.main_et_contraUser)
        val textContraUser = inputContra.text.toString()

        if(textCorreoUser.isNotEmpty() && textContraUser.isNotEmpty()){
            mostrarMensaje("¡¡¡ BIENVENIDO !!!\nCorreo: $textCorreoUser")
            val intent = Intent(this, FormularioActivity::class.java)
            startActivity(intent)

        } else {
            mostrarMensaje("Ingrese el correo o contraseña")
        }


    }
}