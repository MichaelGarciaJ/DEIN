package com.mariana.kudage

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import android.widget.Toast

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when(item.itemId){
            R.id.share_action, R.id.send_action -> {
//                mostrarToast(Title, Toast.LENGTH_LONG)
                true
            }

            R.id.delete_action -> {
                true
            }

            else -> onOptionsItemSelected(item)
        }
    }

}