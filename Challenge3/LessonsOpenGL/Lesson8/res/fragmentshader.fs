#version 330 core
out vec4 FragColor;

in vec3 ourColor; // we set this variable in the OpenGL code.
in vec2 TexCoord;
uniform sampler2D ourTexture;

void main()
{
	FragColor = texture(ourTexture, TexCoord);
}