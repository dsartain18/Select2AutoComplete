# Select2AutoComplete
The purpose of this repository is to demonstrate some of the ways to customize the Select2 AutoComplete/Dropdown UI control.

# Project Origins
This project started because I worked on a help center page where the help articles were PDF or DOCX files that a user could download vs web pages. We broke the different help articles into different tabs based on category, but wanted a way to search across all categories. Given that the articles themselves weren't web pages, it didn't make sense to take them to a new landing page with matching results.

# Why Select2
I initially used the built-in jQuery AutoComplete to search and display the results, but we needed to change the behavior of the click event to allow for two different options: Download a document or open a media link to Vimeo, YouTube, etc. This meant that we had to templatize the results. Select2 offered a bit better support for templating than jQuery AutoComplete did.

# Technology Stack
I went with the MVC and Web API combo for this demo because I wanted to provide a more real-world example that included the AJAX call to get the search results from an API, and even though I originally wanted to steer clear of MVC for displaying the example I also wanted the example to just work out of the box and creating a HomeController and leveraging the default MVC behavior made that possible.

# Bundles
I opted not to use bundles for this example because there is only one page and I wanted to clearly show which JavaScript and CSS files were necessary to get this to work.

# HTML Element
With other AutoComplete implementations, you start with a text input. If you do that with Select2 you'll wind up with a bit of an inception autocomplete box. While that works great as a joke to send your product owner, it doesn't look all that great. So, I changed it to a DIV to avoid that.

# CSS Changes
The main CSS changes that are necessary are in site.css and exist to override the default Select2 behavior for selectable options. It is necessary to re-implement their classes to acheive this override because Select2 essentially adds a wrapper HTML element around the HTML element (DIV) that I specified as the Select2 element. So, adding a new class or ID with a distinct name won't work, even though that would normally be my preference.

# JavaScript Notes
In the example I have a few things that don't have to co-exist to get this to work. I handle the .on("select2-selecting") and .on("select2-select") events as well as override the .onSelect() event. In the .onSelect there is an else statement that is commented out. In my case, I did this because I only want clickable actions to happen if the user clicks either the download button or the media link. I don't want them to actually click the option and select it. If you do want them to be able to do that, uncomment the else statement. If you uncomment the else statement, that will trigger the .on("select2-selecting") and subsequently the .on("select2-select") events. As it is now, doing so will cause the same behavior because I prevent the default behavior to make sure that they can't select the option in case anyone comes behind me and uncomments that line (in the real project). Normally I would just delete this, but I didn't want to lose the example of how to continue on with the selection in case we need it in the future.

