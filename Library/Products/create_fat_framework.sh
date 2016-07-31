framework_name=SwiftSample && \
cp -R Release-iphoneos/$framework_name.framework ./$framework_name.framework && \
lipo -create -output "$framework_name.framework/$framework_name" \
"Release-iphonesimulator/$framework_name.framework/$framework_name" \
"Release-iphoneos/$framework_name.framework/$framework_name" 