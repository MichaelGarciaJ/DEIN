package com.mariana.kudage

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.Menu
import androidx.appcompat.widget.PopupMenu
import android.view.MenuItem
import android.view.View
import android.widget.ImageView
import android.widget.Toast
import androidx.appcompat.widget.Toolbar

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        // Configurar la Toolbar como ActionBar
        val toolbar = findViewById<Toolbar>(R.id.toolbar)
        setSupportActionBar(toolbar)

        val moreButton: ImageView = findViewById(R.id.more_actions_button)
        moreButton.setOnClickListener { view ->
            showMoreActionsMenu(view)
        }
    }

    private fun showMoreActionsMenu(button: View) {
        val popup = PopupMenu(this, button)
        popup.menuInflater.inflate(R.menu.popup_menu, popup.menu)

        popup.setOnMenuItemClickListener { item ->
            when (item.itemId) {
                R.id.add_favorites -> {
                    mostrarToast("Añadiendo a favoritos...", Toast.LENGTH_SHORT)
                    true
                }
                R.id.share -> {
                    mostrarToast("Compartiendo...", Toast.LENGTH_SHORT)
                    true
                }
                R.id.move -> {
                    mostrarToast("Moviendo a...", Toast.LENGTH_SHORT)
                    true
                }

                else -> false
            }
        }

        popup.show()
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        menuInflater.inflate(R.menu.main_menu, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when(item.itemId){
            R.id.share_action, R.id.send_action -> {
                mostrarToast(item.title.toString(), Toast.LENGTH_LONG)
                true
            }
            R.id.edit_action -> {
                mostrarToast("Editando elemento...", Toast.LENGTH_SHORT)
                true
            }
            R.id.delete_action -> {
                mostrarToast("Item eliminado", Toast.LENGTH_SHORT)
                true
            }
            R.id.settings -> {
                goToSettings()
                true
            }

            else -> super.onOptionsItemSelected(item)
        }
    }

    private fun mostrarToast(message: String, duration: Int) {
        Toast.makeText(this, message, duration).show()
    }

    private fun goToSettings() {
        Toast.makeText(this, "Navegando a Ajustes", Toast.LENGTH_SHORT).show()
        val intent = Intent(this, SettingsActivity::class.java)
        startActivity(intent)
    }


}