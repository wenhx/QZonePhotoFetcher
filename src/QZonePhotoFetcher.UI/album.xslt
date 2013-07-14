<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>
          <xsl:value-of select="name"/>
        </title>
      </head>
      <body>
        <table border="0">
          <xsl:apply-templates select="album/photos/photo[position() mod 5 = 1]"/>
        </table>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="photo">
    <tr>
      <xsl:for-each select=". | following-sibling::photo[position() &lt; 5]">
        <td>
          <a target="_blank">
            <xsl:attribute name="href">
              <xsl:value-of select="url" />
            </xsl:attribute>
            <img>
              <xsl:attribute name="src">
                <xsl:value-of select="thumb" />
              </xsl:attribute>
            </img>
          </a>
        </td>
      </xsl:for-each>
    </tr>
  </xsl:template>
</xsl:stylesheet>