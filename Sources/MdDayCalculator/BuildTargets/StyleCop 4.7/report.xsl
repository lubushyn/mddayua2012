<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"
omit-xml-declaration="no" />
<xsl:template match="StyleCopViolations">
<html>
<head>
    <title>Initialization from table</title>
    <script src="http://teamcitywp7.yallapop.cogniance.com/jquery.min.js"></script>
    <script src="http://teamcitywp7.yallapop.cogniance.com/kendo.web.min.js"></script>
    <link href="http://teamcitywp7.yallapop.cogniance.com/kendo.common.min.css" rel="stylesheet" />
    <link href="http://teamcitywp7.yallapop.cogniance.com/kendo.default.min.css" rel="stylesheet" />
</head>
    <body>
         <div>
        <table id="grid">
             <thead>
                    <tr>
                        <th data-field="rule">Rule</th>
                        <th data-field="description">Rule Description</th>
                        <th data-field="source">Source</th>
                        <th data-field="lineNumber">Line number</th>
                    </tr>
                </thead>
<tbody>
<xsl:apply-templates select="Violation"></xsl:apply-templates>
</tbody>
        </table>
         <script>
                $(document).ready(function() {
                    $("#grid").kendoGrid({
                    groupable: true,
                    sortable: true,
                    filterable: true
                    });
                });
            </script>
        </div>
    </body>
</html>
</xsl:template>
<xsl:template match="Violation">
<tr>
    <td>
        <xsl:value-of select="@Rule" />
    </td>
    <td>
<xsl:value-of select="." />
</td>
<td>
<xsl:value-of select="@Source" />
</td>
<td>
<xsl:value-of select="@LineNumber" />
</td>
</tr>
</xsl:template>
</xsl:stylesheet>