import matplotlib.pyplot as plt
import numpy as np
import sys
import json

json_data = sys.argv[1]

categories = json.loads(json_data)
#categories = {"Puma":2,"Adidas":4}
print(sys.argv[1])

# Crear la figura y los ejes con fondo oscuro
fig, ax = plt.subplots(figsize=(16, 6))
fig.patch.set_facecolor('#0e1726')  # Fondo de la figura
ax.set_facecolor('#0e1726')  # Fondo del eje

# Crear barras con un degradado
for i, key in enumerate(categories):
    ax.bar(
        key, 
        categories[key], 
        color=plt.cm.cool(i / len(categories)),  # Usar un mapa de colores
        edgecolor='white', 
        linewidth=1.5,
    )
    # Anotación de valores sobre cada barra

# Personalizar la gráfica
ax.spines['bottom'].set_color('#c4c4c4')
ax.spines['left'].set_color('#c4c4c4')
ax.tick_params(axis='x', colors='white')
ax.tick_params(axis='y', colors='white')
ax.tick_params(axis='x', colors='white', labelsize=16)  # Aquí aumentas el tamaño de las etiquetas del eje X
ax.tick_params(axis='y', colors='white', labelsize=14)
ax.set_title("Venta por marca", fontsize=28, weight='bold', color='white')
ax.set_xlabel("Marca", fontsize=22, color='white')
ax.set_ylabel("Ventas", fontsize=22, color='white')
ax.yaxis.grid(color='#444444', linestyle='--', linewidth=0.7)

# Mostrar la gráfica
plt.tight_layout()
plt.savefig("grafica_barras.png", dpi=300)  # Aquí defines el nombre y formato de la imagen
plt.close()  # Cerrar la figura para liberar recursos
