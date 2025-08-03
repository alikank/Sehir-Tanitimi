package com.example.sehirtanitim;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import android.view.MenuItem;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    private WebView webView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // WebView’i tanımla
        webView = findViewById(R.id.webview);
        webView.getSettings().setJavaScriptEnabled(true);
        webView.setWebViewClient(new WebViewClient());  // Dış tarayıcıya gitmesin
        WebSettings webSettings = webView.getSettings();
        webSettings.setJavaScriptEnabled(true);  // JS destekle
        webView.setWebViewClient(new WebViewClient());  // WebView içinde açsın

        // Başlangıçta ilk sayfa
        webView.loadUrl("file:///android_asset/index.html");

        // Menü (BottomNavigationView) tanımla
        BottomNavigationView bottomNav = findViewById(R.id.bottom_navigation);
        bottomNav.setOnItemSelectedListener(item -> {
            switch (item.getItemId()) {
                case R.id.nav_home:
                    webView.loadUrl("file:///android_asset/index.html");
                    return true;
                case R.id.nav_page1:
                    webView.loadUrl("file:///android_asset/population.html");
                    return true;
                case R.id.nav_page2:
                    webView.loadUrl("file:///android_asset/district.html");
                    return true;
                case R.id.nav_page3:
                    webView.loadUrl("file:///android_asset/place.html");
                    return true;
            }
            return false;
        });
    }

    // Geri tuşu WebView içindeyken geri gitsin
    @Override
    public void onBackPressed() {
        if (webView.canGoBack()) {
            webView.goBack();
        } else {
            super.onBackPressed();
        }
    }
}
