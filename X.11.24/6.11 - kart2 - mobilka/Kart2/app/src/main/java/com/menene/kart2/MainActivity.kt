package com.menene.kart2

import android.os.Bundle
import android.view.View
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.menene.kart2.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    lateinit var bind: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        bind = ActivityMainBinding.inflate(layoutInflater)
        setContentView(bind.root)

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        bind.confirmButton.setOnClickListener {
            val email: String = bind.email.text.toString()
            val password: String = bind.password.text.toString()
            val confirmedPassword: String = bind.confirmedPassword.text.toString()
            val atAmount: Int = Regex("@").findAll(email).count()

            if (password == confirmedPassword){
                if (atAmount == 1){
                    bind.output.text = getString(R.string.email, email)
                } else {
                    Toast.makeText(this, getString(R.string.invalid_email), Toast.LENGTH_SHORT).show()
                }
            } else {
                Toast.makeText(this, getString(R.string.different_passwords), Toast.LENGTH_SHORT).show()
            }
        }
    }
}