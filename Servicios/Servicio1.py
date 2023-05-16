from flask import Flask, request, jsonify
import os
import re
import firebase_admin
from firebase_admin import credentials
from firebase_admin import firestore

app = Flask(__name__)
app.debug = True


# Configurar la conexión con Firebase
cred = credentials.Certificate('Servicios\SW.json')
firebase_admin.initialize_app(cred)
db = firestore.client()
usuarios_sistema_ref = db.collection('usuarios_sistema')

# Ruta para el registro de usuarios
@app.route('/registro', methods=['POST'])
def registrar_usuario():
    # Obtener los datos del usuario del cuerpo de la solicitud POST
    datos_usuario = request.get_json()
    nombre = datos_usuario.get('nombre')
    correo = datos_usuario.get('correo')
    contraseña = datos_usuario.get('contrasena')

    # Validar que el usuario esté disponible
    if usuarios_sistema_ref.document(correo).get().exists:
        return jsonify({'error': 'El usuario ya existe'}), 401

    # Validar el formato del correo electrónico utilizando una expresión regular
    if not re.match(r"[^@]+@[^@]+\.[^@]+", correo):
        return jsonify({'error': 'Formato de correo electrónico inválido'}), 402

    # Validar la fortaleza de la contraseña
    if len(contraseña) < 8:
        return jsonify({'error': 'La contraseña debe tener al menos 8 caracteres'}), 403

    # Almacenar los datos del usuario en la base de datos
    usuarios_sistema_ref.document(correo).set({
        'nombre': nombre,
        'correo': correo,
        'contraseña': contraseña
    })

    return '', 201

if __name__ == '__main__':
    app.run()
