package com.mariana.kudage

import android.content.Intent
import android.os.Bundle
import android.os.Handler
import android.os.Looper
import androidx.appcompat.app.AppCompatActivity

class SplashActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_splash)

        // Usar el constructor de Handler que acepta un Lopper
        Handler(Looper.getMainLooper()).postDelayed({

            // Crea un Intent para iniciar la actividad principal
            val intent = Intent(this@SplashActivity, MainActivity::class.java)
            startActivity(intent)
            finish()
        }, 3000) // 3000 milisegundos = 3 segundos
    }


}