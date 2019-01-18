max=100000
for i in `seq 1 $max`
do
    echo "INSERT INTO \`HeavilyRequestedObjects\` (SomeProperty, AnotherImportantProperty) VALUES ('SomeProperty $i', 'AnotherImportantProperty $i');"
done