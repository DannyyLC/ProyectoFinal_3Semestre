import matplotlib.pyplot as plt
import numpy as np

# Datos de ejemplo
categories = ['Nike', 'Adidas', 'UnderArmour', 'Puma']
values = [5, 7, 6, 8]

# Crear la figura y los ejes con fondo oscuro
fig, ax = plt.subplots(figsize=(16, 6))
fig.patch.set_facecolor('#0e1726')  # Fondo de la figura
ax.set_facecolor('#0e1726')  # Fondo del eje

# Crear barras con un degradado
for i, value in enumerate(values):
    ax.bar(
        categories[i], 
        value, 
        color=plt.cm.cool(i / len(values)),  # Usar un mapa de colores
        edgecolor='white', 
        linewidth=1.5,
    )
    # Anotación de valores sobre cada barra
    ax.text(
        i, value + 10, f'{value:.2f}', 
        ha='center', color='white', fontsize=16
    )

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