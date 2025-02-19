plugins {
    id("com.android.application")
    id("org.jetbrains.kotlin.android")

    /* Persistencia de datos con Room */
    kotlin("kapt")
}

android {
    namespace = "com.mariana.kudage"
    compileSdk = 34

    defaultConfig {
        applicationId = "com.mariana.kudage"
        minSdk = 24
        targetSdk = 33
        versionCode = 1
        versionName = "1.0"

        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(
                getDefaultProguardFile("proguard-android-optimize.txt"),
                "proguard-rules.pro"
            )
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
    kotlinOptions {
        jvmTarget = "1.8"
    }
}

dependencies {

    implementation("androidx.preference:preference:1.2.0")
    val room_version = "2.5.0"


    /* ROOM DB */
    implementation("androidx.room:room-runtime:$room_version")
    kapt("androidx.room:room-compiler:$room_version")
    // annotationProcessor("androidx.room:room-compiler:$room_version")

    /* LOCALIZACION */
    implementation("com.google.android.gms:play-services-location:21.1.0")



    /* DEFAULT */
    implementation("androidx.core:core-ktx:1.9.0")
    implementation("androidx.appcompat:appcompat:1.6.1")
    implementation("com.google.android.material:material:1.11.0")
    implementation("androidx.constraintlayout:constraintlayout:2.1.4")
    testImplementation("junit:junit:4.13.2")
    androidTestImplementation("androidx.test.ext:junit:1.1.5")
    androidTestImplementation("androidx.test.espresso:espresso-core:3.5.1")
}